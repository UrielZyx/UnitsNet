//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using UnitsNet.NumberExtensions.NumberToPorousMediumPermeability;
using Xunit;

namespace UnitsNet.Tests
{
    public class NumberToPorousMediumPermeabilityExtensionsTests
    {
        [Fact]
        public void NumberToDarcysTest() =>
            Assert.Equal(PorousMediumPermeability.FromDarcys(2), 2.Darcys());

        [Fact]
        public void NumberToMicrodarcysTest() =>
            Assert.Equal(PorousMediumPermeability.FromMicrodarcys(2), 2.Microdarcys());

        [Fact]
        public void NumberToMillidarcysTest() =>
            Assert.Equal(PorousMediumPermeability.FromMillidarcys(2), 2.Millidarcys());

        [Fact]
        public void NumberToSquareCentimetersTest() =>
            Assert.Equal(PorousMediumPermeability.FromSquareCentimeters(2), 2.SquareCentimeters());

        [Fact]
        public void NumberToSquareMetersTest() =>
            Assert.Equal(PorousMediumPermeability.FromSquareMeters(2), 2.SquareMeters());

    }
}