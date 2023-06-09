﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class popula_produtos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO produto(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriID)"
                   +"Values ('Coca Zero','Coca cola 2 L zero',11.00,'coca-cola_zero.png','50',now(), 1)");

            mb.Sql("INSERT INTO produto(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriID)"
                   + "Values ('Coca ','Coca cola 2 L ',15.00,'coca.png','50',now(), 1)");

            mb.Sql("INSERT INTO produto(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriID)"
                   + "Values ('X-tudo','lanche especial da casa x-tudo',30.00,'xtudo.png','50',now(), 2)");

            mb.Sql("INSERT INTO produto(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriID)"
                   + "Values ('Pizza calabrexa','Pizza de Calabreza com cebola',51.20,'pizza.png','50',now(), 3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("TRUNCATE Produto");
        }
    }
}
