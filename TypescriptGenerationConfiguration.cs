using Reinforced.Typings.Ast.TypeNames;
using Reinforced.Typings.Fluent;
using System;
using System.Collections.Generic;

namespace reinforced {
    public static class TypescriptGenerationConfiguration {
        public static void Configure(ConfigurationBuilder builder) {
            builder.ExportAsInterface<Model>();
        }
    }
}
