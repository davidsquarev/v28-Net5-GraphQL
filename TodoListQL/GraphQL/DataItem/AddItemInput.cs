using System;

namespace TodoListQL.GraphQL.DataItem
{
    public record AddItemInput(string title, string description, bool isDone, int listId, DateTime start, DateTime end);
}