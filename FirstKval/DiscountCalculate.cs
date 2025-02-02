namespace FirstKval;

internal class DiscountCalculate {
    #region Quantity of sold products
    private const ushort _MIN_PROD = 10_000;
    private const ushort _AVERAGE_PROD = 50_000;
    private const int _MAX_PROD = 300_000;
    #endregion

    #region Discounts
    private const byte _MIN_DISCOUNT = 5;
    private const byte _AVERAGE_DISCOUNT = 10;
    private const byte _MAX_DISCOUNT = 15;
    #endregion

    public static byte GetDiscount(uint numOfSoldProducts) {
        if (numOfSoldProducts < _MIN_PROD)
            return 0;

        if (numOfSoldProducts < _AVERAGE_PROD)
            return _MIN_DISCOUNT;

        if (numOfSoldProducts < _MAX_PROD)
            return _AVERAGE_DISCOUNT;

        return _MAX_DISCOUNT;
    }
}
