﻿//
// This file is part of Monobjc, a .NET/Objective-C bridge
// Copyright (C) 2007-2013 - Laurent Etiemble
//
// Monobjc is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// any later version.
//
// Monobjc is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with Monobjc.  If not, see <http://www.gnu.org/licenses/>.
//
using System;
using System.Globalization;
using System.IO;
using Monobjc.Tools.Utilities;

namespace Monobjc.Tools.External
{
    /// <summary>
    ///   Wrapper class around the <c>install_name_tool</c> command line tool.
    /// </summary>
    public static class InstallNameTool
    {
        /// <summary>
        ///   Change, TextWriter outputWriter = null, TextWriter errorWriter = null)s the id of the given library.
        /// </summary>
        /// <param name = "library">The library.</param>
        /// <param name = "newId">The new id.</param>
        public static void ChangeId(String library, String newId, TextWriter outputWriter = null, TextWriter errorWriter = null)
        {
            String arguments = String.Format(CultureInfo.InvariantCulture, "-id \"{1}\" \"{0}\"", library, newId);
            ProcessHelper helper = new ProcessHelper(Executable, arguments);
			helper.OutputWriter = outputWriter;
			helper.ErrorWriter = errorWriter;
			helper.Execute ();
        }

        /// <summary>
        ///   Changes a dependency for the given library.
        /// </summary>
        /// <param name = "library">The library.</param>
        /// <param name = "oldDependency">The old dependency.</param>
        /// <param name = "newDependency">The new dependency.</param>
        public static void ChangeDependency(String library, String oldDependency, String newDependency, TextWriter outputWriter = null, TextWriter errorWriter = null)
        {
            String arguments = String.Format(CultureInfo.InvariantCulture, "-change \"{1}\" \"{2}\" \"{0}\"", library, oldDependency, newDependency);
            ProcessHelper helper = new ProcessHelper(Executable, arguments);
			helper.OutputWriter = outputWriter;
			helper.ErrorWriter = errorWriter;
			helper.Execute ();
        }

        private static string Executable
        {
            get { return "/usr/bin/install_name_tool"; }
        }
    }
}