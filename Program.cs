try{






string [] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt"); // cada linha vai ficar como se fosse um array.

foreach(string linha in linhas){
    System.Console.WriteLine(linha);
}

} 
catch(FileNotFoundException ex){
    System.Console.WriteLine("Ocorreu um erro na leitura do arquivo" +ex.Message);
}
catch(DirectoryNotFoundException ex){
    System.Console.WriteLine("Ocorreu um erro ao encontrar o diretório , ou seja, caminho da pasta"+ex.Message);
}
catch(Exception ex){
    System.Console.WriteLine("Ocorreu uma exceção genérica"+ex.Message);
}

finally{
    System.Console.WriteLine("Chegou até aqui!");
}

