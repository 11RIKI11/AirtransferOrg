using КП.Core.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace КП.Infrastructure
{
    public static class MessageDisplay
    {
        private static Form _parentForm;
        private static List<MessageTimer> _messageTimers;

        static MessageDisplay()
        {
            _messageTimers = new List<MessageTimer>();
        }

        public static void RegisterParentForm(Form parentForm)
        {
            _parentForm = parentForm;
            SubscribeToParentPanelEvents();
        }

        /// <summary>
        /// Отображает сообщение на экране в виде всплывающего окна.
        /// </summary>
        /// <param name="message">Текст сообщения, который будет отображен в окне.</param>
        /// <param name="messageType">Тип сообщения, определяющий его цвет и иконку (например, успешное сообщение, ошибка и т.д.).</param>
        /// <param name="title">Необязательный параметр. Заголовок окна сообщения. Если не указан, используется заголовок по умолчанию в зависимости от типа сообщения.</param>
        public static void ShowMessage(string message, MessageType messageType, string title = null)
        {
            if (_messageTimers.Count >= 3)
            {
                CloseMessage(_messageTimers.Count - 1);
            }

            var messagePanel = CreateMessagePanel(message, messageType, title);
            var messageTimer = new MessageTimer
            {
                Panel = messagePanel,
                Timer = new System.Threading.Timer(TimerCallback, messagePanel, 5000, Timeout.Infinite)
            };
            _messageTimers.Insert(0, messageTimer);

            _parentForm.Controls.Add(messagePanel);
            _parentForm.Controls.SetChildIndex(messagePanel, 0);
            messagePanel.Visible = true;
            
            UpdateMessagePositions();
        }

        #region Родительская панель

        private static void SubscribeToParentPanelEvents()
        {
            if (_parentForm != null)
            {
                _parentForm.Resize += (sender, args) => UpdateMessagePositions();
                _parentForm.SizeChanged += ParentPanel_SizeChanged;
                _parentForm.Move += (sender, args) => UpdateMessagePositions();
            }
        }

        private static void UnsubscribeFromParentPanelEvents()
        {
            if (_parentForm != null)
            {
                _parentForm.Resize -= (sender, args) => UpdateMessagePositions();
                _parentForm.SizeChanged -= ParentPanel_SizeChanged;
                _parentForm.Move -= (sender, args) => UpdateMessagePositions();
            }
        }

        #endregion

        #region Управление сообщениями

        private static void TimerCallback(object state)
        {
            var messagePanel = state as Panel;
            if (messagePanel != null && _parentForm != null)
            {
                _parentForm.Invoke((MethodInvoker)(() =>
                {
                    CloseMessage(_messageTimers.FindIndex(mt => mt.Panel == messagePanel));
                }));
            }
        }

        private static void ParentPanel_SizeChanged(object sender, EventArgs e)
        {
            UpdateMessagePositions();
        }

        private static void UpdateMessagePositions()
        {
            if (_parentForm != null)
            {
                int offsetY = 200;

                foreach (var messageTimer in _messageTimers)
                {
                    SetMessagePanelPosition(messageTimer.Panel, offsetY);
                    offsetY += messageTimer.Panel.Height + 10;
                }
            }
        }

        private static void CloseMessage(int index)
        {
            if (_messageTimers.Count > 0)
            {
                var messageTimer = _messageTimers[index];
                _messageTimers.RemoveAt(index);

                messageTimer.Timer.Dispose();

                var panelToRemove = messageTimer.Panel;
                panelToRemove.Visible = false;

                UpdateMessagePositions();
            }
        }

        private static void SetMessagePanelPosition(Panel messagePanel, int offsetY)
        {
            if (_parentForm != null)
            {
                int formWidth = _parentForm.ClientSize.Width;
                int formHeight = _parentForm.ClientSize.Height;

                messagePanel.Location = new Point(
                    formWidth - messagePanel.Width - 30, 
                    formHeight - offsetY                 
                );
            }
        }

        #endregion

        #region Создание панели сообщения

        private static Panel CreateMessagePanel(string message, MessageType messageType, string title)
        {
            var messagePanel = new Panel
            {
                Size = new Size(350, 150),
                BackColor = Color.Black,
                Padding = new Padding(10),
                BorderStyle = BorderStyle.None
            };

            var tableLayoutPanel = new TableLayoutPanel
            {
                RowCount = 3,
                ColumnCount = 1,
                Dock = DockStyle.Fill,
                BackColor = Color.Black,
                AutoSize = true
            };

            var headerPanel = CreateHeaderPanel(messageType, title);
            var separatorLine = CreateSeparatorLine(messageType);

            tableLayoutPanel.Controls.Add(headerPanel, 0, 0);
            tableLayoutPanel.Controls.Add(separatorLine, 0, 1);
            tableLayoutPanel.Controls.Add(new Label { Text = message, Font = new Font("Arial", 12), AutoSize = false, ForeColor = Color.White, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 0, 2);

            messagePanel.Controls.Add(tableLayoutPanel);

            messagePanel.Click += (s, e) => CloseMessage(_messageTimers.FindIndex(mt => mt.Panel == messagePanel));
            AttachClickEvent(messagePanel, (s, e) => CloseMessage(_messageTimers.FindIndex(mt => mt.Panel == messagePanel)));

            return messagePanel;
        }

        private static void AttachClickEvent(Control control, EventHandler handler)
        {
            control.Click += handler;
            foreach (Control child in control.Controls)
            {
                AttachClickEvent(child, handler);
            }
        }

        private static FlowLayoutPanel CreateHeaderPanel(MessageType messageType, string title)
        {
            var headerPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                AutoSize = true,
            };

            var iconLabel = new Label
            {
                Text = GetIconTextByMessageType(messageType),
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = GetIconColorByMessageType(messageType),
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                Padding = new Padding(70, 0, 0, 0),
            };

            var titleLabel = new Label
            {
                Text = " " + (title ?? GetDefaultTitleByMessageType(messageType)),
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true
            };

            headerPanel.Controls.Add(iconLabel);
            headerPanel.Controls.Add(titleLabel);
            return headerPanel;
        }

        private static Label CreateSeparatorLine(MessageType messageType)
        {
            return new Label
            {
                AutoSize = false,
                Height = 1,
                Dock = DockStyle.Top,
                BackColor = GetIconColorByMessageType(messageType),
                Margin = new Padding(0, 10, 0, 10)
            };
        }

        private static Color GetIconColorByMessageType(MessageType messageType) =>
            messageType switch
            {
                MessageType.Success => Color.LightGreen,
                MessageType.Error => Color.Red,
                MessageType.Warning => Color.Orange,
                MessageType.Info => Color.LightBlue,
                _ => Color.Gray
            };

        private static string GetIconTextByMessageType(MessageType messageType) =>
            messageType switch
            {
                MessageType.Success => "✓",
                MessageType.Error => "×",
                MessageType.Warning => "!",
                MessageType.Info => "?",
                _ => "?"
            };

        private static string GetDefaultTitleByMessageType(MessageType messageType) =>
            messageType switch
            {
                MessageType.Success => "Успешно",
                MessageType.Error => "Ошибка",
                MessageType.Warning => "Внимание",
                MessageType.Info => "Информация",
                _ => "Сообщение"
            };

        #endregion

        private class MessageTimer
        {
            public Panel Panel { get; set; }
            public System.Threading.Timer Timer { get; set; }
        }
    }
}
