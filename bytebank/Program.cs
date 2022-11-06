using bytebank;

ContaCorrente contaDoMarcio = new ContaCorrente();
contaDoMarcio.conta = "1000";
contaDoMarcio.titular = "Márcio Viana";
contaDoMarcio.numero_agencia = 15;
contaDoMarcio.saldo = 100;

Console.WriteLine("Saldo da conta do Márcio : R$ " + contaDoMarcio.saldo);