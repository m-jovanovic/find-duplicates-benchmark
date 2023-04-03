namespace FindDuplicates;

public enum Location
{
    /// <summary>
    /// There is no duplicate
    /// </summary>
    None,
    /// <summary>
    /// The duplicate is located at the beginning
    /// </summary>
    Beginning,
    /// <summary>
    /// The duplicate is located 41% in the sequence
    /// </summary>
    FortyOnePercent,
    /// <summary>
    /// The duplicate is located at the end
    /// </summary>
    End
}