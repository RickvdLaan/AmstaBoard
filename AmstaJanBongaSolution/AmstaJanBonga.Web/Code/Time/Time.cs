using Rlaan.Toolkit.Extensions;

public sealed class Time
{
    #region Variables & Objects

    private int _minutes;

    private const int MIN_MINUTES = 0;
    private const int MAX_MINUTES = 1439;

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets the minutes.
    /// </summary>
    public int TotalMinutes
    {
        get { return this._minutes; }
        private set
        {
            if (value > MAX_MINUTES)
                this._minutes = MAX_MINUTES;
            else if (value < MIN_MINUTES)
                this._minutes = MIN_MINUTES;

            this._minutes = value;
        }
    }

    public int Hour
    {
        get { return TotalMinutes / 60; }
    }

    public int Minutes
    {
        get { return TotalMinutes % 60; }
    }

    #endregion

    #region Constructor

    /// <summary>
    /// Constructor of the Time object, this class cannot be inherited.
    /// </summary>
    /// <param name="minutes">Provide the minutes after 00:00.</param>
    public Time(int minutes)
    {
        this.TotalMinutes = minutes;
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
            this.Hour.ToString().Length    == 1 ? "0" + this.Hour    : this.Hour.ToString(),
            this.Minutes.ToString().Length == 1 ? "0" + this.Minutes : this.Minutes.ToString());

        return time;
    }

    #endregion
}