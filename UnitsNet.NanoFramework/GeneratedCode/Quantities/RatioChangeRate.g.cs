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
using UnitsNet.Units;

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     The change in ratio per unit of time.
    /// </summary>
    public struct  RatioChangeRate
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly RatioChangeRateUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public RatioChangeRateUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public RatioChangeRate(double value, RatioChangeRateUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static RatioChangeRateUnit BaseUnit { get; } = RatioChangeRateUnit.DecimalFractionPerSecond;

        /// <summary>
        /// Represents the largest possible value of RatioChangeRate.
        /// </summary>
        public static RatioChangeRate MaxValue { get; } = new RatioChangeRate(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of RatioChangeRate.
        /// </summary>
        public static RatioChangeRate MinValue { get; } = new RatioChangeRate(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static RatioChangeRate Zero { get; } = new RatioChangeRate(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RatioChangeRateUnit.DecimalFractionPerSecond"/>
        /// </summary>
        public double DecimalFractionsPerSecond => As(RatioChangeRateUnit.DecimalFractionPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="RatioChangeRateUnit.PercentPerSecond"/>
        /// </summary>
        public double PercentsPerSecond => As(RatioChangeRateUnit.PercentPerSecond);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="RatioChangeRate"/> from <see cref="RatioChangeRateUnit.DecimalFractionPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RatioChangeRate FromDecimalFractionsPerSecond(double decimalfractionspersecond) => new RatioChangeRate(decimalfractionspersecond, RatioChangeRateUnit.DecimalFractionPerSecond);

        /// <summary>
        ///     Creates a <see cref="RatioChangeRate"/> from <see cref="RatioChangeRateUnit.PercentPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RatioChangeRate FromPercentsPerSecond(double percentspersecond) => new RatioChangeRate(percentspersecond, RatioChangeRateUnit.PercentPerSecond);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="RatioChangeRateUnit" /> to <see cref="RatioChangeRate" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>RatioChangeRate unit value.</returns>
        public static RatioChangeRate From(double value, RatioChangeRateUnit fromUnit)
        {
            return new RatioChangeRate(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(RatioChangeRateUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A Duration with the specified unit.</returns>
                public RatioChangeRate ToUnit(RatioChangeRateUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new RatioChangeRate(convertedValue, unit);
                }

                /// <summary>
                ///     Converts the current value + unit to the base unit.
                ///     This is typically the first step in converting from one unit to another.
                /// </summary>
                /// <returns>The value in the base unit representation.</returns>
                private double GetValueInBaseUnit()
                {
                    return Unit switch
                    {
                        RatioChangeRateUnit.DecimalFractionPerSecond => _value,
                        RatioChangeRateUnit.PercentPerSecond => _value / 1e2,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(RatioChangeRateUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        RatioChangeRateUnit.DecimalFractionPerSecond => baseUnitValue,
                        RatioChangeRateUnit.PercentPerSecond => baseUnitValue * 1e2,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}

