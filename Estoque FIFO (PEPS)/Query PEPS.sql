Create database ProjetoPEPS
go 
Use ProjetoPEPS;
go 

-- cadastro produtos 
create table produto
( idproduto int primary key, 
  nome varchar(255),
  detalhes varchar(255), 
  fornecedor varchar(255),
  custo decimal(10,3)
  )
go 

-- Estoque 
create table Estoque 
( idEstoque int primary key identity,  
  idproduto int references Produto(idproduto),
  Recebimento date default(getdate()), 
  Operacao varchar(255),
  Quantidade int 
)
go

-- cadastro de pedidos 
Create table pedidos 
( 
  idpedido int primary key, 
  DiaVenda date default(getdate()), 
  NomeCliente varchar(255), 
)
go 

create table Itens_pedido 
(
 idItemPedido int primary key, 
 idproduto int references produto(idproduto),
 idpedido int references Pedidos(idpedido),
 Nome varchar(255),
 quantidade int,
 custoVenda decimal(10,2)  
 )  
 go