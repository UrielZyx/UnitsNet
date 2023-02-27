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

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using UnitsNet.Tests.TestsBase;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of RotationalAcceleration.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class RotationalAccelerationTestsBase : QuantityTestsBase
    {
        protected abstract double DegreesPerSecondSquaredInOneRadianPerSecondSquared { get; }
        protected abstract double RadiansPerSecondSquaredInOneRadianPerSecondSquared { get; }
        protected abstract double RevolutionsPerMinutePerSecondInOneRadianPerSecondSquared { get; }
        protected abstract double RevolutionsPerSecondSquaredInOneRadianPerSecondSquared { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double DegreesPerSecondSquaredTolerance { get { return 1e-5; } }
        protected virtual double RadiansPerSecondSquaredTolerance { get { return 1e-5; } }
        protected virtual double RevolutionsPerMinutePerSecondTolerance { get { return 1e-5; } }
        protected virtual double RevolutionsPerSecondSquaredTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(RotationalAccelerationUnit unit)
        {
            return unit switch
            {
                RotationalAccelerationUnit.DegreePerSecondSquared => (DegreesPerSecondSquaredInOneRadianPerSecondSquared, DegreesPerSecondSquaredTolerance),
                RotationalAccelerationUnit.RadianPerSecondSquared => (RadiansPerSecondSquaredInOneRadianPerSecondSquared, RadiansPerSecondSquaredTolerance),
                RotationalAccelerationUnit.RevolutionPerMinutePerSecond => (RevolutionsPerMinutePerSecondInOneRadianPerSecondSquared, RevolutionsPerMinutePerSecondTolerance),
                RotationalAccelerationUnit.RevolutionPerSecondSquared => (RevolutionsPerSecondSquaredInOneRadianPerSecondSquared, RevolutionsPerSecondSquaredTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { RotationalAccelerationUnit.DegreePerSecondSquared },
            new object[] { RotationalAccelerationUnit.RadianPerSecondSquared },
            new object[] { RotationalAccelerationUnit.RevolutionPerMinutePerSecond },
            new object[] { RotationalAccelerationUnit.RevolutionPerSecondSquared },
        };

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new RotationalAcceleration();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(RotationalAccelerationUnit.RadianPerSecondSquared, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RotationalAcceleration(double.PositiveInfinity, RotationalAccelerationUnit.RadianPerSecondSquared));
            Assert.Throws<ArgumentException>(() => new RotationalAcceleration(double.NegativeInfinity, RotationalAccelerationUnit.RadianPerSecondSquared));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RotationalAcceleration(double.NaN, RotationalAccelerationUnit.RadianPerSecondSquared));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new RotationalAcceleration(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new RotationalAcceleration(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (RotationalAcceleration) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void RotationalAcceleration_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new RotationalAcceleration(1, RotationalAccelerationUnit.RadianPerSecondSquared);

            QuantityInfo<RotationalAccelerationUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(RotationalAcceleration.Zero, quantityInfo.Zero);
            Assert.Equal("RotationalAcceleration", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<RotationalAccelerationUnit>().OrderBy(x => x.ToString()).ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void RadianPerSecondSquaredToRotationalAccelerationUnits()
        {
            RotationalAcceleration radianpersecondsquared = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            AssertEx.EqualTolerance(DegreesPerSecondSquaredInOneRadianPerSecondSquared, radianpersecondsquared.DegreesPerSecondSquared, DegreesPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(RadiansPerSecondSquaredInOneRadianPerSecondSquared, radianpersecondsquared.RadiansPerSecondSquared, RadiansPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(RevolutionsPerMinutePerSecondInOneRadianPerSecondSquared, radianpersecondsquared.RevolutionsPerMinutePerSecond, RevolutionsPerMinutePerSecondTolerance);
            AssertEx.EqualTolerance(RevolutionsPerSecondSquaredInOneRadianPerSecondSquared, radianpersecondsquared.RevolutionsPerSecondSquared, RevolutionsPerSecondSquaredTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = RotationalAcceleration.From(1, RotationalAccelerationUnit.DegreePerSecondSquared);
            AssertEx.EqualTolerance(1, quantity00.DegreesPerSecondSquared, DegreesPerSecondSquaredTolerance);
            Assert.Equal(RotationalAccelerationUnit.DegreePerSecondSquared, quantity00.Unit);

            var quantity01 = RotationalAcceleration.From(1, RotationalAccelerationUnit.RadianPerSecondSquared);
            AssertEx.EqualTolerance(1, quantity01.RadiansPerSecondSquared, RadiansPerSecondSquaredTolerance);
            Assert.Equal(RotationalAccelerationUnit.RadianPerSecondSquared, quantity01.Unit);

            var quantity02 = RotationalAcceleration.From(1, RotationalAccelerationUnit.RevolutionPerMinutePerSecond);
            AssertEx.EqualTolerance(1, quantity02.RevolutionsPerMinutePerSecond, RevolutionsPerMinutePerSecondTolerance);
            Assert.Equal(RotationalAccelerationUnit.RevolutionPerMinutePerSecond, quantity02.Unit);

            var quantity03 = RotationalAcceleration.From(1, RotationalAccelerationUnit.RevolutionPerSecondSquared);
            AssertEx.EqualTolerance(1, quantity03.RevolutionsPerSecondSquared, RevolutionsPerSecondSquaredTolerance);
            Assert.Equal(RotationalAccelerationUnit.RevolutionPerSecondSquared, quantity03.Unit);

        }

        [Fact]
        public void FromRadiansPerSecondSquared_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => RotationalAcceleration.FromRadiansPerSecondSquared(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => RotationalAcceleration.FromRadiansPerSecondSquared(double.NegativeInfinity));
        }

        [Fact]
        public void FromRadiansPerSecondSquared_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => RotationalAcceleration.FromRadiansPerSecondSquared(double.NaN));
        }

        [Fact]
        public void As()
        {
            var radianpersecondsquared = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            AssertEx.EqualTolerance(DegreesPerSecondSquaredInOneRadianPerSecondSquared, radianpersecondsquared.As(RotationalAccelerationUnit.DegreePerSecondSquared), DegreesPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(RadiansPerSecondSquaredInOneRadianPerSecondSquared, radianpersecondsquared.As(RotationalAccelerationUnit.RadianPerSecondSquared), RadiansPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(RevolutionsPerMinutePerSecondInOneRadianPerSecondSquared, radianpersecondsquared.As(RotationalAccelerationUnit.RevolutionPerMinutePerSecond), RevolutionsPerMinutePerSecondTolerance);
            AssertEx.EqualTolerance(RevolutionsPerSecondSquaredInOneRadianPerSecondSquared, radianpersecondsquared.As(RotationalAccelerationUnit.RevolutionPerSecondSquared), RevolutionsPerSecondSquaredTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new RotationalAcceleration(value: 1, unit: RotationalAcceleration.BaseUnit);
            Func<object> AsWithSIUnitSystem = () => quantity.As(UnitSystem.SI);

            if (SupportsSIUnitSystem)
            {
                var value = Convert.ToDouble(AsWithSIUnitSystem());
                Assert.Equal(1, value);
            }
            else
            {
                Assert.Throws<ArgumentException>(AsWithSIUnitSystem);
            }
        }

        [Fact]
        public void Parse()
        {
            try
            {
                var parsed = RotationalAcceleration.Parse("1 °/s²", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.DegreesPerSecondSquared, DegreesPerSecondSquaredTolerance);
                Assert.Equal(RotationalAccelerationUnit.DegreePerSecondSquared, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = RotationalAcceleration.Parse("1 deg/s²", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.DegreesPerSecondSquared, DegreesPerSecondSquaredTolerance);
                Assert.Equal(RotationalAccelerationUnit.DegreePerSecondSquared, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = RotationalAcceleration.Parse("1 rad/s²", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.RadiansPerSecondSquared, RadiansPerSecondSquaredTolerance);
                Assert.Equal(RotationalAccelerationUnit.RadianPerSecondSquared, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = RotationalAcceleration.Parse("1 rpm/s", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.RevolutionsPerMinutePerSecond, RevolutionsPerMinutePerSecondTolerance);
                Assert.Equal(RotationalAccelerationUnit.RevolutionPerMinutePerSecond, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = RotationalAcceleration.Parse("1 r/s²", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.RevolutionsPerSecondSquared, RevolutionsPerSecondSquaredTolerance);
                Assert.Equal(RotationalAccelerationUnit.RevolutionPerSecondSquared, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParse()
        {
            {
                Assert.True(RotationalAcceleration.TryParse("1 °/s²", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.DegreesPerSecondSquared, DegreesPerSecondSquaredTolerance);
                Assert.Equal(RotationalAccelerationUnit.DegreePerSecondSquared, parsed.Unit);
            }

            {
                Assert.True(RotationalAcceleration.TryParse("1 deg/s²", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.DegreesPerSecondSquared, DegreesPerSecondSquaredTolerance);
                Assert.Equal(RotationalAccelerationUnit.DegreePerSecondSquared, parsed.Unit);
            }

            {
                Assert.True(RotationalAcceleration.TryParse("1 rad/s²", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.RadiansPerSecondSquared, RadiansPerSecondSquaredTolerance);
                Assert.Equal(RotationalAccelerationUnit.RadianPerSecondSquared, parsed.Unit);
            }

            {
                Assert.True(RotationalAcceleration.TryParse("1 rpm/s", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.RevolutionsPerMinutePerSecond, RevolutionsPerMinutePerSecondTolerance);
                Assert.Equal(RotationalAccelerationUnit.RevolutionPerMinutePerSecond, parsed.Unit);
            }

            {
                Assert.True(RotationalAcceleration.TryParse("1 r/s²", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.RevolutionsPerSecondSquared, RevolutionsPerSecondSquaredTolerance);
                Assert.Equal(RotationalAccelerationUnit.RevolutionPerSecondSquared, parsed.Unit);
            }

        }

        [Fact]
        public void ParseUnit()
        {
            try
            {
                var parsedUnit = RotationalAcceleration.ParseUnit("°/s²", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(RotationalAccelerationUnit.DegreePerSecondSquared, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = RotationalAcceleration.ParseUnit("deg/s²", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(RotationalAccelerationUnit.DegreePerSecondSquared, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = RotationalAcceleration.ParseUnit("rad/s²", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(RotationalAccelerationUnit.RadianPerSecondSquared, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = RotationalAcceleration.ParseUnit("rpm/s", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(RotationalAccelerationUnit.RevolutionPerMinutePerSecond, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = RotationalAcceleration.ParseUnit("r/s²", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(RotationalAccelerationUnit.RevolutionPerSecondSquared, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParseUnit()
        {
            {
                Assert.True(RotationalAcceleration.TryParseUnit("°/s²", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(RotationalAccelerationUnit.DegreePerSecondSquared, parsedUnit);
            }

            {
                Assert.True(RotationalAcceleration.TryParseUnit("deg/s²", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(RotationalAccelerationUnit.DegreePerSecondSquared, parsedUnit);
            }

            {
                Assert.True(RotationalAcceleration.TryParseUnit("rad/s²", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(RotationalAccelerationUnit.RadianPerSecondSquared, parsedUnit);
            }

            {
                Assert.True(RotationalAcceleration.TryParseUnit("rpm/s", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(RotationalAccelerationUnit.RevolutionPerMinutePerSecond, parsedUnit);
            }

            {
                Assert.True(RotationalAcceleration.TryParseUnit("r/s²", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(RotationalAccelerationUnit.RevolutionPerSecondSquared, parsedUnit);
            }

        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(RotationalAccelerationUnit unit)
        {
            var inBaseUnits = RotationalAcceleration.From(1.0, RotationalAcceleration.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(RotationalAccelerationUnit unit)
        {
            var quantity = RotationalAcceleration.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(RotationalAccelerationUnit unit)
        {
            // See if there is a unit available that is not the base unit, fallback to base unit if it has only a single unit.
            var fromUnit = RotationalAcceleration.Units.First(u => u != RotationalAcceleration.BaseUnit);

            var quantity = RotationalAcceleration.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public virtual void ToUnit_FromDefaultQuantity_ReturnsQuantityWithGivenUnit(RotationalAccelerationUnit unit)
        {
            var quantity = default(RotationalAcceleration);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            RotationalAcceleration radianpersecondsquared = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            AssertEx.EqualTolerance(1, RotationalAcceleration.FromDegreesPerSecondSquared(radianpersecondsquared.DegreesPerSecondSquared).RadiansPerSecondSquared, DegreesPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, RotationalAcceleration.FromRadiansPerSecondSquared(radianpersecondsquared.RadiansPerSecondSquared).RadiansPerSecondSquared, RadiansPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, RotationalAcceleration.FromRevolutionsPerMinutePerSecond(radianpersecondsquared.RevolutionsPerMinutePerSecond).RadiansPerSecondSquared, RevolutionsPerMinutePerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalAcceleration.FromRevolutionsPerSecondSquared(radianpersecondsquared.RevolutionsPerSecondSquared).RadiansPerSecondSquared, RevolutionsPerSecondSquaredTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            RotationalAcceleration v = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            AssertEx.EqualTolerance(-1, -v.RadiansPerSecondSquared, RadiansPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(2, (RotationalAcceleration.FromRadiansPerSecondSquared(3)-v).RadiansPerSecondSquared, RadiansPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(2, (v + v).RadiansPerSecondSquared, RadiansPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(10, (v*10).RadiansPerSecondSquared, RadiansPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(10, (10*v).RadiansPerSecondSquared, RadiansPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(2, (RotationalAcceleration.FromRadiansPerSecondSquared(10)/5).RadiansPerSecondSquared, RadiansPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(2, RotationalAcceleration.FromRadiansPerSecondSquared(10)/RotationalAcceleration.FromRadiansPerSecondSquared(5), RadiansPerSecondSquaredTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            RotationalAcceleration oneRadianPerSecondSquared = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            RotationalAcceleration twoRadiansPerSecondSquared = RotationalAcceleration.FromRadiansPerSecondSquared(2);

            Assert.True(oneRadianPerSecondSquared < twoRadiansPerSecondSquared);
            Assert.True(oneRadianPerSecondSquared <= twoRadiansPerSecondSquared);
            Assert.True(twoRadiansPerSecondSquared > oneRadianPerSecondSquared);
            Assert.True(twoRadiansPerSecondSquared >= oneRadianPerSecondSquared);

            Assert.False(oneRadianPerSecondSquared > twoRadiansPerSecondSquared);
            Assert.False(oneRadianPerSecondSquared >= twoRadiansPerSecondSquared);
            Assert.False(twoRadiansPerSecondSquared < oneRadianPerSecondSquared);
            Assert.False(twoRadiansPerSecondSquared <= oneRadianPerSecondSquared);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            RotationalAcceleration radianpersecondsquared = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            Assert.Equal(0, radianpersecondsquared.CompareTo(radianpersecondsquared));
            Assert.True(radianpersecondsquared.CompareTo(RotationalAcceleration.Zero) > 0);
            Assert.True(RotationalAcceleration.Zero.CompareTo(radianpersecondsquared) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            RotationalAcceleration radianpersecondsquared = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            Assert.Throws<ArgumentException>(() => radianpersecondsquared.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            RotationalAcceleration radianpersecondsquared = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            Assert.Throws<ArgumentNullException>(() => radianpersecondsquared.CompareTo(null));
        }

        [Theory]
        [InlineData(1, RotationalAccelerationUnit.RadianPerSecondSquared, 1, RotationalAccelerationUnit.RadianPerSecondSquared, true)]  // Same value and unit.
        [InlineData(1, RotationalAccelerationUnit.RadianPerSecondSquared, 2, RotationalAccelerationUnit.RadianPerSecondSquared, false)] // Different value.
        [InlineData(2, RotationalAccelerationUnit.RadianPerSecondSquared, 1, RotationalAccelerationUnit.DegreePerSecondSquared, false)] // Different value and unit.
        [InlineData(1, RotationalAccelerationUnit.RadianPerSecondSquared, 1, RotationalAccelerationUnit.DegreePerSecondSquared, false)] // Different unit.
        public void Equals_ReturnsTrue_IfValueAndUnitAreEqual(double valueA, RotationalAccelerationUnit unitA, double valueB, RotationalAccelerationUnit unitB, bool expectEqual)
        {
            var a = new RotationalAcceleration(valueA, unitA);
            var b = new RotationalAcceleration(valueB, unitB);

            // Operator overloads.
            Assert.Equal(expectEqual, a == b);
            Assert.Equal(expectEqual, b == a);
            Assert.Equal(!expectEqual, a != b);
            Assert.Equal(!expectEqual, b != a);

            // IEquatable<T>
            Assert.Equal(expectEqual, a.Equals(b));
            Assert.Equal(expectEqual, b.Equals(a));

            // IEquatable
            Assert.Equal(expectEqual, a.Equals((object)b));
            Assert.Equal(expectEqual, b.Equals((object)a));
        }

        [Fact]
        public void Equals_Null_ReturnsFalse()
        {
            var a = RotationalAcceleration.Zero;

            Assert.False(a.Equals((object)null));

            // "The result of the expression is always 'false'..."
            #pragma warning disable CS8073
            Assert.False(a == null);
            Assert.False(null == a);
            Assert.True(a != null);
            Assert.True(null != a);
            #pragma warning restore CS8073
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            Assert.True(v.Equals(RotationalAcceleration.FromRadiansPerSecondSquared(1), RadiansPerSecondSquaredTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(RotationalAcceleration.Zero, RadiansPerSecondSquaredTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(RotationalAcceleration.FromRadiansPerSecondSquared(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            RotationalAcceleration radianpersecondsquared = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            Assert.False(radianpersecondsquared.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            RotationalAcceleration radianpersecondsquared = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            Assert.False(radianpersecondsquared.Equals(null));
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(RotationalAccelerationUnit)).Cast<RotationalAccelerationUnit>();
            foreach (var unit in units)
            {
                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(RotationalAcceleration.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 °/s²", new RotationalAcceleration(1, RotationalAccelerationUnit.DegreePerSecondSquared).ToString());
                Assert.Equal("1 rad/s²", new RotationalAcceleration(1, RotationalAccelerationUnit.RadianPerSecondSquared).ToString());
                Assert.Equal("1 rpm/s", new RotationalAcceleration(1, RotationalAccelerationUnit.RevolutionPerMinutePerSecond).ToString());
                Assert.Equal("1 r/s²", new RotationalAcceleration(1, RotationalAccelerationUnit.RevolutionPerSecondSquared).ToString());
            }
            catch
            {
                throw;
            }
            finally
            {
                Thread.CurrentThread.CurrentCulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 °/s²", new RotationalAcceleration(1, RotationalAccelerationUnit.DegreePerSecondSquared).ToString(swedishCulture));
            Assert.Equal("1 rad/s²", new RotationalAcceleration(1, RotationalAccelerationUnit.RadianPerSecondSquared).ToString(swedishCulture));
            Assert.Equal("1 rpm/s", new RotationalAcceleration(1, RotationalAccelerationUnit.RevolutionPerMinutePerSecond).ToString(swedishCulture));
            Assert.Equal("1 r/s²", new RotationalAcceleration(1, RotationalAccelerationUnit.RevolutionPerSecondSquared).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 rad/s²", new RotationalAcceleration(0.123456, RotationalAccelerationUnit.RadianPerSecondSquared).ToString("s1"));
                Assert.Equal("0.12 rad/s²", new RotationalAcceleration(0.123456, RotationalAccelerationUnit.RadianPerSecondSquared).ToString("s2"));
                Assert.Equal("0.123 rad/s²", new RotationalAcceleration(0.123456, RotationalAccelerationUnit.RadianPerSecondSquared).ToString("s3"));
                Assert.Equal("0.1235 rad/s²", new RotationalAcceleration(0.123456, RotationalAccelerationUnit.RadianPerSecondSquared).ToString("s4"));
            }
            catch
            {
                throw;
            }
            finally
            {
                CultureInfo.CurrentCulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 rad/s²", new RotationalAcceleration(0.123456, RotationalAccelerationUnit.RadianPerSecondSquared).ToString("s1", culture));
            Assert.Equal("0.12 rad/s²", new RotationalAcceleration(0.123456, RotationalAccelerationUnit.RadianPerSecondSquared).ToString("s2", culture));
            Assert.Equal("0.123 rad/s²", new RotationalAcceleration(0.123456, RotationalAccelerationUnit.RadianPerSecondSquared).ToString("s3", culture));
            Assert.Equal("0.1235 rad/s²", new RotationalAcceleration(0.123456, RotationalAccelerationUnit.RadianPerSecondSquared).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = RotationalAcceleration.FromRadiansPerSecondSquared(1.0);
            CultureInfo formatProvider = cultureName == null
                ? null
                : CultureInfo.GetCultureInfo(cultureName);

            Assert.Equal(quantity.ToString("g", formatProvider), quantity.ToString(null, formatProvider));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("g")]
        public void ToString_NullProvider_EqualsCurrentCulture(string format)
        {
            var quantity = RotationalAcceleration.FromRadiansPerSecondSquared(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = RotationalAcceleration.FromRadiansPerSecondSquared(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = RotationalAcceleration.FromRadiansPerSecondSquared(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = RotationalAcceleration.FromRadiansPerSecondSquared(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = RotationalAcceleration.FromRadiansPerSecondSquared(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = RotationalAcceleration.FromRadiansPerSecondSquared(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = RotationalAcceleration.FromRadiansPerSecondSquared(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = RotationalAcceleration.FromRadiansPerSecondSquared(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = RotationalAcceleration.FromRadiansPerSecondSquared(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = RotationalAcceleration.FromRadiansPerSecondSquared(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = RotationalAcceleration.FromRadiansPerSecondSquared(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = RotationalAcceleration.FromRadiansPerSecondSquared(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = RotationalAcceleration.FromRadiansPerSecondSquared(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = RotationalAcceleration.FromRadiansPerSecondSquared(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = RotationalAcceleration.FromRadiansPerSecondSquared(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = RotationalAcceleration.FromRadiansPerSecondSquared(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = RotationalAcceleration.FromRadiansPerSecondSquared(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(RotationalAcceleration)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = RotationalAcceleration.FromRadiansPerSecondSquared(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(RotationalAccelerationUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = RotationalAcceleration.FromRadiansPerSecondSquared(1.0);
            Assert.Equal(RotationalAcceleration.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = RotationalAcceleration.FromRadiansPerSecondSquared(1.0);
            Assert.Equal(RotationalAcceleration.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = RotationalAcceleration.FromRadiansPerSecondSquared(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = RotationalAcceleration.FromRadiansPerSecondSquared(1.0);
            Assert.Equal(new {RotationalAcceleration.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = RotationalAcceleration.FromRadiansPerSecondSquared(value);
            Assert.Equal(RotationalAcceleration.FromRadiansPerSecondSquared(-value), -quantity);
        }
    }
}
