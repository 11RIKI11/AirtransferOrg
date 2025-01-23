using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using КП.Infrastructure;

public static class DataGridViewHelper
{
    // Словарь для хранения информации о колонках и их валидационных методах для каждого грида
    private static readonly List<GridValidationInfo> gridValidationInfoList = new List<GridValidationInfo>();

    // Метод для добавления колонки с возможностью задания названия и списка валидационных правил
    public static void AddColumn(DataGridView grid, string columnName, string headerText, List<string> validationMethods = null)
    {
        if (grid == null) return;
        
        // Находим уже существующую запись для грида
        var gridInfo = gridValidationInfoList.Find(g => g.Grid == grid);
        if (gridInfo == null)
        {
            // Если такой записи нет, добавляем новую
            gridInfo = new GridValidationInfo(grid);
            gridValidationInfoList.Add(gridInfo);
        }

        // Добавляем колонку в DataGridView
        grid.Columns.Add(columnName, headerText);

        // Если для колонки указаны методы валидации, добавляем их в список
        if (validationMethods != null)
        {
            List<Func<string, string>> methods = new List<Func<string, string>>();
            foreach (var methodName in validationMethods)
            {
                var method = typeof(DataGridViewHelper).GetMethod(methodName);
                if (method != null && method.IsStatic)
                {
                    methods.Add((Func<string, string>)Delegate.CreateDelegate(typeof(Func<string, string>), method));
                }
                else
                {
                    throw new NotImplementedException();
                }
            }

            gridInfo.ValidationRules[columnName] = methods;
        }

        // Подписка на событие для автоматической валидации
        grid.CellValidating += Grid_CellValidating;
    }

    // Метод для автоматической валидации при выходе из ячейки
    private static void Grid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
    {
        DataGridView grid = sender as DataGridView;
        if (grid == null) return;

        string value = e.FormattedValue?.ToString().Trim();
        string columnName = grid.Columns[e.ColumnIndex].Name;
        string errorMessage = string.Empty;

        // Находим соответствующую запись для грида
        var gridInfo = gridValidationInfoList.Find(g => g.Grid == grid);
        if (gridInfo != null && gridInfo.ValidationRules.ContainsKey(columnName))
        {
            foreach (var validate in gridInfo.ValidationRules[columnName])
            {
                errorMessage = validate(value);
                if (!string.IsNullOrEmpty(errorMessage))
                {
                    break; // Останавливаем валидацию при первой ошибке
                }
            }
        }

        // Если ошибка валидации, отменяем выход из ячейки
        if (!string.IsNullOrEmpty(errorMessage))
        {
            e.Cancel = true; // Запрещаем выход из ячейки
            MessageDisplay.ShowMessage(errorMessage, КП.Core.Enums.MessageType.Error, "Ошибка валидации");
        }
    }

    public static string ValidateFirstName(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return "Имя не может быть пустым.";
        }
        if (!Regex.IsMatch(value, "^[А-ЯЁA-Z][а-яёa-z]{1,}$"))
        {
            return "Имя должно начинаться с заглавной буквы и содержать минимум 2 символа.";
        }
        return string.Empty;
    }

    // Валидация фамилии (начинается с заглавной буквы, минимум 2 символа)
    public static string ValidateLastName(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return "Фамилия не может быть пустой.";
        }
        if (!Regex.IsMatch(value, "^[А-ЯЁA-Z][а-яёa-z]{1,}$"))
        {
            return "Фамилия должна начинаться с заглавной буквы и содержать минимум 2 символа.";
        }
        return string.Empty;
    }

    // Валидация номера телефона
    public static string ValidatePhone(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return "Номер телефона не может быть пустым.";
        }
        // Формат телефона: +7 (XXX) XXX-XX-XX (или с другими кодами)
        if (!Regex.IsMatch(value, @"^\+?[78]([0-9]{10})$"))
        {
            return "Некорректный формат номера телефона.";
        }
        return string.Empty;
    }

    // Валидация ОГРН (должен состоять из 13 цифр)
    public static string ValidateOgrn(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return "ОГРН не может быть пустым.";
        }
        if (!Regex.IsMatch(value, @"^\d{13}$"))
        {
            return "ОГРН должен состоять из 13 цифр.";
        }
        return string.Empty;
    }

    // Валидация даты (проверка на корректную дату)
    public static string ValidateDate(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return "Дата не может быть пустой.";
        }
        if (!DateTime.TryParse(value, out _))
        {
            return "Некорректный формат даты.";
        }
        return string.Empty;
    }

    // Класс для хранения информации о валидационных правилах и гридах
    private class GridValidationInfo
    {
        public DataGridView Grid { get; }
        public Dictionary<string, List<Func<string, string>>> ValidationRules { get; }

        public GridValidationInfo(DataGridView grid)
        {
            Grid = grid;
            ValidationRules = new Dictionary<string, List<Func<string, string>>>();
        }
    }
}
