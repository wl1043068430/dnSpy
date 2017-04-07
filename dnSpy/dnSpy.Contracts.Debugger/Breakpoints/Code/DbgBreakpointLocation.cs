﻿/*
    Copyright (C) 2014-2017 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

namespace dnSpy.Contracts.Debugger.Breakpoints.Code {
	/// <summary>
	/// Breakpoint location
	/// </summary>
	public abstract class DbgBreakpointLocation : DbgObject {
		/// <summary>
		/// Unique type, see <see cref="PredefinedDbgBreakpointLocationTypes"/>. There should
		/// be a 1-1 correspondence between this string and the derived type.
		/// </summary>
		public abstract string Type { get; }

		/// <summary>
		/// Compares this instance to <paramref name="obj"/>
		/// </summary>
		/// <param name="obj">Object</param>
		/// <returns></returns>
		public abstract override bool Equals(object obj);

		/// <summary>
		/// Gets the hash code
		/// </summary>
		/// <returns></returns>
		public abstract override int GetHashCode();
	}
}