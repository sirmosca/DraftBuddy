using System;
using DraftBuddy.Common.Enumerations;

namespace DraftBuddy.Service
{
    public class PositionText
    {
        public Position GetPosition(string position)
        {
            switch (position)
            {
                case "QB":
                    return Position.QuarterBack;
                case "RB":
                    return Position.RunningBack;
                case "WR":
                    return Position.WideReceiver;
                case "DEF":
                    return Position.Defense;
                case "TE":
                    return Position.TightEnd;
                case "PK":
                    return Position.Kicker;
                default:
                    throw new ArgumentException(string.Format("incorrect position {0}", position));
            }
        }

        public string GetPosition(Position position)
        {
            switch (position)
            {
                case Position.QuarterBack:
                    return "QB";
                case Position.RunningBack:
                    return "RB";
                case Position.WideReceiver:
                    return "WR";
                case Position.TightEnd:
                    return "TE";
                case Position.Defense:
                    return "DEF";
                case Position.Kicker:
                    return "PK";
                default:
                    throw new ArgumentOutOfRangeException(string.Format("incorrect position {0}", position));
            }
        }
    }
}