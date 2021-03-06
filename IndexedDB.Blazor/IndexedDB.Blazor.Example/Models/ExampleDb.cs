﻿using Microsoft.JSInterop;

namespace IndexedDB.Blazor.Example.Models
{
    public class ExampleDb : IndexedDb
    {
        public ExampleDb(IJSRuntime jSRuntime, string name, int version) : base(jSRuntime, name, version) { }

        public IndexedSet<Person> People { get; set; }
    }
}
