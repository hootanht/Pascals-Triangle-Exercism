using System;
using System.Collections.Generic;
using System.Linq;
public static class PascalsTriangle
{
    public static IEnumerable<IEnumerable<int>> Calculate(int rows)
    {
        //negative rows
        if (rows < 0) throw new ArgumentOutOfRangeException("Invalid value for rows parameter. Number of rows cannot be negative.");
        //zero rows
        var allRows = new List<List<int>>();
        if (rows == 0) return allRows;
        //one row
        var firstRow = new List<int> { 1 };
        allRows.Add(firstRow);
        if (rows == 1) return allRows;
        //two rows
        var secondRow = new List<int> { 1, 1 };
        allRows.Add(secondRow);
        if (rows == 2) return allRows;
        //more than two rows
        for (int i = 3; i <= rows; i++)
        {
            var lastRow = allRows.Last();
            var newRow = new List<int> { 1 };
            for (int j = 0; j <= lastRow.Count() - 2; j++)
            {
                newRow.Add(lastRow[j] + lastRow[j + 1]);
            }
            newRow.Add(1);
            allRows.Add(newRow);
        }
        return allRows;
    }
}