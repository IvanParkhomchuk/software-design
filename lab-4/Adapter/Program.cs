using Adapter;

Logger logger = new Logger();

logger.Log("Log method");
logger.Warn("Warn method");
logger.Error("Error method");

FileLoggerAdapter fileLoggerAdapter = new FileLoggerAdapter();

fileLoggerAdapter.Log("Some log 1");
fileLoggerAdapter.Warn("Some log 2");
fileLoggerAdapter.Error("Some log 3");