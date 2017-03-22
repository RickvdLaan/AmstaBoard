using Rlaan.Toolkit.Extensions;

public sealed class Time
{
    #region Variables & Objects

    private int _hour, _minutes;

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets the hour in 24 hour format.
    /// </summary>
    public int Hour
    {
        get { return this._hour; }
        set
        {
            if (value > 24)
                this._hour = 24;
            else if (value < 0)
                this._hour = 0;

            this._hour = value;
        }
    }

    /// <summary>
    /// Gets or sets the minutes.
    /// </summary>
    public int Minutes
    {
        get { return this._minutes; }
        set
        {
            if (value > 60)
                this._minutes = 60;
            else if (value < 0)
                this._minutes = 0;

            this._minutes = value;
        }
    }

    #endregion

    #region Constructor

    /// <summary>
    /// Constructor of the Time object, this class cannot be inherited.
    /// </summary>
    /// <param name="hour">Provide the hour in 24 hour format.</param>
    /// <param name="minutes">Provide the minutes.</param>
    public Time(int hour, int minutes)
    {
        this.Hour = hour;
        this.Minutes = minutes;
    }

    #endregion

    #region Overrides

    /// <summary>
    /// Returns a string in hh:mm format.
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        var time = "{0}:{1}".FormatString(
            this.Hour.ToString().Length == 1 ? "0" + this.Hour : this.Hour.ToString(),
            this.Minutes.ToString().Length == 1 ? "0" + this.Minutes : this.Minutes.ToString());

        return time;
    }

    #endregion
}