namespace FractionLib;

public readonly struct Fraction
{
    // հայտարարվել է կոտորակի համարիչ համար դաշտ
    // private քանի, որ դրսից հասանելիություն չունի, այսինքն այն կառավարվում է կլասի ներսում
    // readonly-ն նշանակում է, որ դաշտին արժեքը տրվում է runtime և մեկ անգամ, այնուհետեև չի փոխվում
    // նմանապես հայտարարվել է հայտարար
    private readonly int _numerator;
    private readonly int _denominator;

    // կոնստրուկտոր, որի միջոցով արժեքներ ենք տալիս համարիչին և հայտարարին
    public Fraction(int numerator, int denominator)
    {
        // եթե հայտարարը զրո է, ապա նետում է exception ArgumentException,
        // քանի որ արգումենտը(հայտարարը) 0 չի կարող լինել
        if (denominator == 0)
            throw new ArgumentException("Denominator cannot be zero");

        // տալիս ենք արժեքներ համարիչին և հայտարարին
        _numerator = numerator;
        _denominator = denominator;
    }

    // operator overloading - օպերատորի գերբեռնում,
    // //մաթեմատիկական գործողությունների համար
    public static Fraction operator +(Fraction a) => a; // օպերատորի գերբեռնում
    public static Fraction operator -(Fraction a) => new Fraction(-a._numerator, a._denominator); // օպերատորի գերբեռնում

    public static Fraction operator +(Fraction a, Fraction b) => new Fraction(a._numerator * b._denominator + a._denominator * b._numerator, a._denominator * b._denominator); // օպերատորի գերբեռնում
    public static Fraction operator -(Fraction a, Fraction b) => a + (-b); // օպերատորի գերբեռնում

    public static Fraction operator *(Fraction a, Fraction b) => new Fraction(a._numerator * b._numerator, a._denominator * b._denominator); // օպերատորի գերբեռնում
    public static Fraction operator /(Fraction a, Fraction b)
    {
        // եթե b կոտորակի համարիչը լինի 0, ապա կոտորակը կլինի 0 և կոտորակի 0-ի բաժանումը անթույլատրելի կլինի
        if(b._numerator == 0)
            throw new DivideByZeroException();
        // այս դեպքում ստեղծվում է նոր կոտորակ
        return new Fraction(a._numerator * b._denominator, a._denominator * b._numerator);
    }

    // համարիչը և հայտարարը դարձնում է string
    public override string ToString()
    {
        return $"{_numerator} / {_denominator}";
    }

}
