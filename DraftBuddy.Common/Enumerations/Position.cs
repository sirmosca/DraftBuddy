using System.ComponentModel;

namespace DraftBuddy.Common.Enumerations
{
    /// <summary>
    /// 
    /// </summary>
    public enum Position
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("QB")]
        QuarterBack = 2,
        /// <summary>
        /// 
        /// </summary>
        [Description("RB")]
        RunningBack = 3,
        /// <summary>
        /// 
        /// </summary>
        [Description("WR")]
        WideReceiver = 5,
        /// <summary>
        /// 
        /// </summary>
        [Description("TE")]
        TightEnd = 4,
        /// <summary>
        /// 
        /// </summary>
        [Description("DEF")]
        Defense = 0,
        /// <summary>
        /// 
        /// </summary>
        [Description("PK")]
        Kicker = 1
    }
}