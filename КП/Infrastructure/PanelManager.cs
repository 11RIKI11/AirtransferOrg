using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace КП.Infrastructure
{
    public static class PanelManager
    {
        private static Dictionary<Type, UserControl> panels = new Dictionary<Type, UserControl>();
        private static UserControl _currentPanel;
        private static UserControl _previousPanel;

        private static Control _parentControl;

        public delegate void PanelChangedEventHandler(object sender, EventArgs e);
        public static event PanelChangedEventHandler PanelChanged;

        public static UserControl CurrentPanel => _currentPanel;

        /// <summary>
        /// Регистрирует панель в менеджере.
        /// </summary>
        public static void RegisterPanel(UserControl panel)
        {
            if (!panels.ContainsKey(panel.GetType()))
            {
                panels[panel.GetType()] = panel;
            }
        } 

        /// <summary>
        /// Переключает на указанную панель.
        /// </summary>
        public static void SwitchTo<T>() where T : UserControl, new()
        {
            if (!panels.TryGetValue(typeof(T), out UserControl newPanel))
            {
                string errorMessage = $"Панель {typeof(T).Name} не зарегистрирована в PanelManager.";
                Logger.Error(errorMessage);
                throw new InvalidOperationException(errorMessage);
            }

            if (_currentPanel != null)
            {
                _previousPanel = _currentPanel;
                _parentControl.Controls.Remove(_currentPanel);
            }

            _currentPanel = newPanel;
            InsertPanelDeepest(_currentPanel);
            OnPanelChanged();
        }

        /// <summary>
        /// Переключает на предыдущую панель.
        /// </summary>
        public static void SwitchBack()
        {
            if (_previousPanel == null)
            {
                string errorMessage = "Нет предыдущей панели для возвращения.";
                Logger.Error(errorMessage);
                throw new InvalidOperationException(errorMessage);
            }

            _parentControl.Controls.Remove(_currentPanel);

            _currentPanel = _previousPanel;
            InsertPanelDeepest(_currentPanel);

            _previousPanel = null;

            OnPanelChanged();
        }

        /// <summary>
        /// Устанавливает родительский контейнер для панелей.
        /// </summary>
        public static void RegistrationParentControl(Control control)
        {
            _parentControl = control;
        }

        private static void InsertPanelDeepest(UserControl panel)
        {
            Control parent = _parentControl;
            while (parent.Controls.Count > 0 && parent.Controls[parent.Controls.Count - 1] is UserControl childPanel)
            {
                parent = childPanel;
            }
            parent.Controls.Add(panel);
            panel.Dock = DockStyle.Fill;
        }

        public static void OnPanelChanged()
        {
            PanelChanged?.Invoke(null, EventArgs.Empty);
        }
    }
}
