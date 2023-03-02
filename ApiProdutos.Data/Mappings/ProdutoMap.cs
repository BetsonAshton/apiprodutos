using ApiProdutos.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProdutos.Data.Mappings
{

    /// <summary>
    /// Classe de mapeamento para a entidade Produto
    /// </summary>
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            //Nome da tabela
            builder.ToTable("PRODUTO");

            //Chave primária
            builder.HasKey(p => p.IdProduto);

            //Mapeamento dos campos
            builder.Property(p => p.Nome)
                .HasColumnName("NOME")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(p => p.Descricao)
                .HasColumnName("DESCRICAO")
                .HasMaxLength(500)
                .IsRequired();

            builder.Property(p => p.Preco)
                .HasColumnName("PRECO")
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(p => p.Quantidade)
                .HasColumnName("QUANTIDADE")
                .IsRequired();

            builder.Property(p => p.DataHoraCadastro)
                .HasColumnName("DATAHORACADASTRO")
                .IsRequired();

            builder.Property(p => p.IdCategoria)
                .HasColumnName("IDCATEGORIA")
                .IsRequired();

            //mapeamento do relacionamento 1 para muitos
            // e da foreign key(chave estranheira)
            builder.HasOne(p => p.Categoria) // Produto tem 1 categoria
                .WithMany(c => c.Produtos) //Categoria tem muitos Produtos
                .HasForeignKey(p => p.IdCategoria); //Chave estrangeira

                
        }
    }
}
