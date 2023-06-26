// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System;

namespace Rock.Attribute
{
    /// <summary>
    /// The IRockBlockType classes marked with this attribute are not registered on Rock Startup
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [AttributeUsage( AttributeTargets.Class )]
    public class ToggleOffBlockAttribute : System.Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToggleOffBlockAttribute"/> class.
        /// </summary>
        public ToggleOffBlockAttribute() { }
    }
}
