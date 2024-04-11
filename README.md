# NGNotification

### Definição: 
- O pacote NGNotification contém estruturas para retorno de mensagens, notificações e exceções.

### Vantagens: 
- Ter estruturas prontas para notificações e retornos.
- Simplificar a adição de mensagens e saidas de métodos após adição.

# Documentação

### Usings:

```ruby
using NGNotification;
using NGNotification.Enums;
using NGNotification.Models;
```

### Implementação NGNotifier:

NGNotifier é a principal classe para controlar notificações, é uma classe estática que contém a lista de notificações e métodos para manipular essa lista.

Se precisar verificar se existe alguma notificação, usar HasNotifications:
```ruby
NGNotifier.HasNotifications
```

Há vários métodos para adicionar mensagens.

Para adicionar uma mensagem simples, usar o método add.

O método exige um INGNotification como parâmetro, que pode ser um NGMessage, NGException ou qualquer estrutura costumizada que herdar a interface em questão.
```ruby
//// Método principal de inicialização com todos os parâmetros  //////////////
NGNotifier.Add(new NGMessage(Category.Message, "Test message", "This is a message test"));
//// Método principal de inicialização apenas com apenas a categoria e mensagem (envia header = "") //////////////
NGNotifier.Add(new NGMessage(Category.Message, "This is a message test"));
//// Método sobrecarga de inicialização apenas com cabeçalho e a mensagem (envia category = Category.None) //////////////
NGNotifier.Add(new NGMessage("Test message", "This is a message test"));
//// Método sobrecarga de inicialização apenas com apenas a mensagem (envia category = Category.None e header = "") //////////////
NGNotifier.Add(new NGMessage(Category.Message, "Test message", "This is a message test"));
//// Método principal de inicialização com cabeçalho e mensagem  //////////////
NGNotifier.Add(new NGException("Test error", "This is a erros test"));
//// Método sobrecarga de inicialização com apenas a mensagem (header = "")
NGNotifier.Add(new NGException("This is a erros test"));
```
> [!NOTE]
> Note que ao adicionar um NGException não necessita categoria pois o mesmo adiciona Category.Error como padrão.

Existe também métodos que auxiliares que gategorizam a mensagem automatico:
```ruby
//// Método para adicionar NGMessage com Category.Log  //////////////
NGNotifier.AddLog("Log test", "This is a log test");
//// Método sobrecarga para adicionar NGMessage com Category.Log e mensagem//////////////
NGNotifier.AddLog("This is a log test");

//// Método para adicionar NGMessage com Category.Message  //////////////
NGNotifier.AddMessage("Message test", "This is a message test");
//// Método sobrecarga para adicionar NGMessage com Category.Message e mensagem//////////////
NGNotifier.AddMessage("This is a message test");

//// Método para adicionar NGMessage com Category.Information  //////////////
NGNotifier.AddInformation("Information test", "This is a Information test");
//// Método sobrecarga para adicionar NGMessage com Category.Log e mensagem//////////////
NGNotifier.AddInformation("This is a Information test");

//// Método para adicionar NGMessage com Category.Warning  //////////////
NGNotifier.AddWarning("Warning test", "This is a Warning test");
//// Método sobrecarga para adicionar NGMessage com Category.Warning e mensagem//////////////
NGNotifier.AddWarning("This is a Warning test");

//// Método para adicionar NGMessage com Category.Error  //////////////
NGNotifier.AddError("Error test", "This is a Error test");
//// Método sobrecarga para adicionar NGMessage com Category.Error e mensagem//////////////
NGNotifier.AddError("This is a Error test");
```

Se precisar adicionar uma mensagem no notifier e retornar alguma existem métodos para isso.

O exemplo abaixo é um método que faz uma validação, adiciona uma mensagem como um erro ou um aviso e sai retornando false
```ruby
public bool Validation(int number)
{
    if (number <= 0)
        return NGNotifier.Add<bool>(false, new NGMessage(Category.Warning, "The nunber is invalid"));

    return true;
}
```
Pode-se retornar qualquer objeto, basta tipar o retorno no método de retorno dinâmico.

Os métodos auxiliares também tem sobregargas se retorno dinâmico.
```ruby
return NGNotifier.Add<bool>(false, new NGMessage(Category.Warning, "This is invalid"));

return NGNotifier.AddLog<object>(new Log() { }, "Log", "Some to log");
return NGNotifier.AddLog<object>(new Log() { }, "Some to log");

return NGNotifier.AddMessage<string>("Return", "Message", "Some message");
return NGNotifier.AddMessage<string>("Return", "Some message");

return NGNotifier.AddInformation<string>("Return", "Information", "Some information");
return NGNotifier.AddInformation<string>("Return", "Some information");

return NGNotifier.AddWarning<bool>(true, "Warning", "Some warning");
return NGNotifier.AddWarning<bool>(false, "Some warning");

return NGNotifier.AddError<int>(-1, "Error", "Some error");
return NGNotifier.AddError<int>(0, "Some error");
```
