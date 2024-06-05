using NLog;
using NLog.Config;
class Program
{
    public static Logger logger = LogManager.GetCurrentClassLogger();

    static void Main(string[] args)
    {
        LogManager.Configuration = new XmlLoggingConfiguration("NLog.config");
        logger.Debug("Starting robot");
        Robot robot = new();
        logger.Info("Starting walk");
        robot.Walk();
        logger.Info("Program ended");
    }
}

class Robot
{
    public static Logger logger = LogManager.GetCurrentClassLogger();
    public void Walk()
    {
        LeftLegMove();
        RightLegMove();
        logger.Info("Walk one stop");

    }

    void LeftLegMove()
    {
        logger.Info("Left leg move");

    }

    void RightLegMove()
    {
        // ADA PROSES
        logger.Info("Right leg move");
    }
}