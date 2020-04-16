using System;

namespace Task3TrianglesSorting
{
    internal class Program
    {
        private static readonly log4net.ILog log = LogHelper.GetLogger();
        
        public static void Main(string[] args)
        {
            var ui = new TriangleUI();
            var app = new TrianglesSortingApp(ui);
            
            try
            {
                app.Run(args[1], args[2], args[3], args[0]);
            }
            catch (IndexOutOfRangeException exception)
            {
                ui.DisplayResult(TriangleUI.Instruction);
                log.Error(exception);
            }
            catch (FormatException exception)
            {
                ui.DisplayResult(TriangleUI.Mistake);
                ui.DisplayResult(TriangleUI.Instruction);
                log.Error(exception);
            }
            catch (ArgumentException exception)
            {
                ui.DisplayResult(TriangleUI.Mistake);
                ui.DisplayResult(TriangleUI.Instruction);
                log.Error(exception);
            }
        }
    }
}