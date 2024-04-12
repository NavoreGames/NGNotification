using Microsoft.VisualBasic.Logging;
using NGNotification;
using NGNotification.Enums;
using NGNotification.Models;

namespace Teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            var ret = NGNotifier.HasNotifications;
            //// M�todo principal de inicializa��o com todos os par�metros  //////////////
            NGNotifier.Add(new NGMessage(Category.Message, "Test message", "This is a message test"));
            //// M�todo principal de inicializa��o apenas com apenas a categoria e mensagem (envia header = "") //////////////
            NGNotifier.Add(new NGMessage(Category.Message, "This is a message test"));
            //// M�todo sobrecarga de inicializa��o apenas com cabe�alho e a mensagem (envia category = Category.None) //////////////
            NGNotifier.Add(new NGMessage("Test message", "This is a message test"));
            //// M�todo sobrecarga de inicializa��o apenas com apenas a mensagem (envia category = Category.None e header = "") //////////////
            NGNotifier.Add(new NGMessage(Category.Message, "Test message", "This is a message test"));
            //// M�todo principal de inicializa��o com cabe�alho e mensagem  //////////////
            NGNotifier.Add(new NGException("Test error", "This is a erros test"));
            //// M�todo sobrecarga de inicializa��o com apenas a mensagem (header = "")
            NGNotifier.Add(new NGException("This is a erros test"));

            //// M�todo para adicionar NGMessage com Category.Log  //////////////
            NGNotifier.AddLog("Log test", "This is a log test");
            //// M�todo sobrecarga para adicionar NGMessage com Category.Log e mensagem//////////////
            NGNotifier.AddLog("This is a log test");

            //// M�todo para adicionar NGMessage com Category.Message  //////////////
            NGNotifier.AddMessage("Message test", "This is a message test");
            //// M�todo sobrecarga para adicionar NGMessage com Category.Message e mensagem//////////////
            NGNotifier.AddMessage("This is a message test");

            //// M�todo para adicionar NGMessage com Category.Information  //////////////
            NGNotifier.AddInformation("Information test", "This is a Information test");
            //// M�todo sobrecarga para adicionar NGMessage com Category.Log e mensagem//////////////
            NGNotifier.AddInformation("This is a Information test");

            //// M�todo para adicionar NGMessage com Category.Warning  //////////////
            NGNotifier.AddWarning("Warning test", "This is a Warning test");
            //// M�todo sobrecarga para adicionar NGMessage com Category.Warning e mensagem//////////////
            NGNotifier.AddWarning("This is a Warning test");

            //// M�todo para adicionar NGMessage com Category.Error  //////////////
            NGNotifier.AddError("Error test", "This is a Error test");
            //// M�todo sobrecarga para adicionar NGMessage com Category.Error e mensagem//////////////
            NGNotifier.AddError("This is a Error test");

            //return NGNotifier.Add<bool>(false, new NGMessage(Category.Warning, "This is invalid"));

            //return NGNotifier.AddLog<object>(new Log() { }, "Log", "Some to log");
            //return NGNotifier.AddLog<object>(new Log() { }, "Some to log");

            //return NGNotifier.AddMessage<string>("Return", "Message", "Some message");
            //return NGNotifier.AddMessage<string>("Return", "Some message");

            //return NGNotifier.AddInformation<string>("Return", "Information", "Some information");
            //return NGNotifier.AddInformation<string>("Return", "Some information");

            //return NGNotifier.AddWarning<bool>(true, "Warning", "Some warning");
            //return NGNotifier.AddWarning<bool>(false, "Some warning");

            //return NGNotifier.AddError<int>(-1, "Error", "Some error");
            //return NGNotifier.AddError<int>(0, "Some error");

        }

        public bool Validation(int number)
        {
            if (number <= 0)
                return NGNotifier.Add<bool>(false, new NGMessage(Category.Warning, "The nunber is invalid"));

            return true;
        }
    }
}
