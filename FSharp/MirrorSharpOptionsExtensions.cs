﻿using System;
using JetBrains.Annotations;
using MirrorSharp.FSharp.Internal;

namespace MirrorSharp.FSharp {
    public static class MirrorSharpOptionsExtensions {
        [NotNull]
        public static MirrorSharpOptions EnableFSharp([NotNull] this MirrorSharpOptions options, [CanBeNull] Action<MirrorSharpFSharpOptions> setup = null) {
            Argument.NotNull(nameof(options), options);

            var fsharp = new MirrorSharpFSharpOptions();
            setup?.Invoke(fsharp);
            options.OtherLanguages.Add(FSharpLanguage.Name, () => new FSharpLanguage(fsharp));
            return options;
        }
    }
}