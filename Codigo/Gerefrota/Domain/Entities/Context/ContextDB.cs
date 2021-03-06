using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Domain.Entities.Context
{
    public partial class ContextDB : DbContext
    {
        public ContextDB()
        {
        }

        public ContextDB(DbContextOptions<ContextDB> options)
            : base(options)
        {
        }

        public virtual DbSet<Abastecimento> Abastecimento { get; set; }
        public virtual DbSet<CategoriaCnh> CategoriaCnh { get; set; }
        public virtual DbSet<CategoriaConsumivel> CategoriaConsumivel { get; set; }
        public virtual DbSet<ConsumivelVeicular> ConsumivelVeicular { get; set; }
        public virtual DbSet<Frota> Frota { get; set; }
        public virtual DbSet<Motorista> Motorista { get; set; }
        public virtual DbSet<Multa> Multa { get; set; }
        public virtual DbSet<RelatorioMecanico> RelatorioMecanico { get; set; }
        public virtual DbSet<SolicitacoesManutencao> SolicitacoesManutencao { get; set; }
        public virtual DbSet<StatusSolicitacao> StatusSolicitacao { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuario { get; set; }
        public virtual DbSet<TiposManutencao> TiposManutencao { get; set; }
        public virtual DbSet<Unidade> Unidade { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Veiculo> Veiculo { get; set; }
        public virtual DbSet<Viagem> Viagem { get; set; }
        public virtual DbSet<Vistoria> Vistoria { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Abastecimento>(entity =>
            {
                entity.ToTable("abastecimento");

                entity.HasIndex(e => e.Id, "ID_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.IdVeiculo, "fk_ABASTECIMENTO_VEICULOS1_idx");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Data)
                    .HasColumnType("date")
                    .HasColumnName("DATA");

                entity.Property(e => e.IdVeiculo)
                    .HasColumnType("int unsigned")
                    .HasColumnName("ID_VEICULO");

                entity.Property(e => e.LeituraOdometro).HasColumnName("LEITURA_ODOMETRO");

                entity.Property(e => e.LitrosAbastecidos).HasColumnName("LITROS_ABASTECIDOS");

                entity.HasOne(d => d.IdVeiculoNavigation)
                    .WithMany(p => p.Abastecimento)
                    .HasForeignKey(d => d.IdVeiculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ABASTECIMENTO_VEICULOS1");
            });

            modelBuilder.Entity<CategoriaCnh>(entity =>
            {
                entity.ToTable("categoria_cnh");

                entity.Property(e => e.Id)
                    .HasColumnType("int unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("DESCRICAO");
            });

            modelBuilder.Entity<CategoriaConsumivel>(entity =>
            {
                entity.ToTable("categoria_consumivel");

                entity.Property(e => e.Id)
                    .HasColumnType("int unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("DESCRICAO");
            });

            modelBuilder.Entity<ConsumivelVeicular>(entity =>
            {
                entity.ToTable("consumivel_veicular");

                entity.HasIndex(e => e.IdCategoriaConsumivel, "fk_CONSUMIVEL_VEICULAR_CATEGORIA_CONSUMIVEL_idx");

                entity.HasIndex(e => e.IdVeiculos, "fk_CONSUMIVEL_VEICULAR_VEICULOS1_idx");

                entity.Property(e => e.Id)
                    .HasColumnType("int unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.DataDespesa)
                    .HasColumnType("date")
                    .HasColumnName("DATA_DESPESA");

                entity.Property(e => e.IdCategoriaConsumivel)
                    .HasColumnType("int unsigned")
                    .HasColumnName("ID_CATEGORIA_CONSUMIVEL");

                entity.Property(e => e.IdVeiculos)
                    .HasColumnType("int unsigned")
                    .HasColumnName("ID_VEICULOS");

                entity.Property(e => e.Valor).HasColumnName("VALOR");

                entity.HasOne(d => d.IdCategoriaConsumivelNavigation)
                    .WithMany(p => p.ConsumivelVeicular)
                    .HasForeignKey(d => d.IdCategoriaConsumivel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CONSUMIVEL_VEICULAR_CATEGORIA_CONSUMIVEL");

                entity.HasOne(d => d.IdVeiculosNavigation)
                    .WithMany(p => p.ConsumivelVeicular)
                    .HasForeignKey(d => d.IdVeiculos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CONSUMIVEL_VEICULAR_VEICULOS1");
            });

            modelBuilder.Entity<Frota>(entity =>
            {
                entity.ToTable("frota");

                entity.HasIndex(e => e.IdUnidade, "fk_FROTA_UNIDADES1_idx");

                entity.Property(e => e.Id)
                    .HasColumnType("int unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(400)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.IdUnidade)
                    .HasColumnType("int unsigned")
                    .HasColumnName("ID_UNIDADE");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TITULO");

                entity.HasOne(d => d.IdUnidadeNavigation)
                    .WithMany(p => p.Frota)
                    .HasForeignKey(d => d.IdUnidade)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_FROTA_UNIDADES1");
            });

            modelBuilder.Entity<Motorista>(entity =>
            {
                entity.ToTable("motorista");

                entity.HasIndex(e => e.Id, "ID_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.IdCategoriaCnh, "fk_MOTORISTAS_CATEGORIA_CNH1_idx");

                entity.HasIndex(e => e.IdUsuario, "fk_MOTORISTAS_USUARIOS1_idx");

                entity.Property(e => e.Id)
                    .HasColumnType("int unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.Cnh)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("CNH")
                    .IsFixedLength(true);

                entity.Property(e => e.IdCategoriaCnh)
                    .HasColumnType("int unsigned")
                    .HasColumnName("ID_CATEGORIA_CNH");

                entity.Property(e => e.IdUsuario)
                    .HasColumnType("int unsigned")
                    .HasColumnName("ID_USUARIO");

                entity.Property(e => e.Validade)
                    .HasColumnType("date")
                    .HasColumnName("VALIDADE");

                entity.HasOne(d => d.IdCategoriaCnhNavigation)
                    .WithMany(p => p.Motorista)
                    .HasForeignKey(d => d.IdCategoriaCnh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_MOTORISTAS_CATEGORIA_CNH1");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Motorista)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_MOTORISTAS_USUARIOS1");
            });

            modelBuilder.Entity<Multa>(entity =>
            {
                entity.ToTable("multa");

                entity.HasIndex(e => e.IdViagem, "fk_MULTA_VIAGEM1_idx");

                entity.Property(e => e.Id)
                    .HasColumnType("int unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.IdViagem)
                    .HasColumnType("int unsigned")
                    .HasColumnName("ID_VIAGEM");

                entity.Property(e => e.QtdPontos).HasColumnName("QTD_PONTOS");

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(15,2)")
                    .HasColumnName("VALOR");

                entity.HasOne(d => d.IdViagemNavigation)
                    .WithMany(p => p.Multa)
                    .HasForeignKey(d => d.IdViagem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_MULTA_VIAGEM1");
            });

            modelBuilder.Entity<RelatorioMecanico>(entity =>
            {
                entity.ToTable("relatorio_mecanico");

                entity.HasIndex(e => e.Id, "ID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.ValorPecas)
                    .HasColumnType("decimal(15,2)")
                    .HasColumnName("VALOR_PECAS");

                entity.Property(e => e.ValorServico)
                    .HasColumnType("decimal(15,2)")
                    .HasColumnName("VALOR_SERVICO");

                entity.Property(e => e.ValorTotal)
                    .HasColumnType("decimal(15,2)")
                    .HasColumnName("VALOR_TOTAL");
            });

            modelBuilder.Entity<SolicitacoesManutencao>(entity =>
            {
                entity.ToTable("solicitacoes_manutencao");

                entity.HasIndex(e => e.IdStatusSolicitacao, "fk_SOLICITACOES_MANUTENCAO_STATUS_SOLICITACAO1_idx");

                entity.HasIndex(e => e.IdTiposManutencao, "fk_SOLICITACOES_MANUTENCAO_TIPOS_MANUTENCAO1_idx");

                entity.HasIndex(e => e.IdVeiculo, "fk_SOLICITACOES_MANUTENCAO_VEICULOS1_idx");

                entity.Property(e => e.Id)
                    .HasColumnType("int unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.Data)
                    .HasColumnType("date")
                    .HasColumnName("DATA");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(300)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.IdStatusSolicitacao)
                    .HasColumnType("int unsigned")
                    .HasColumnName("ID_STATUS_SOLICITACAO");

                entity.Property(e => e.IdTiposManutencao).HasColumnName("ID_TIPOS_MANUTENCAO");

                entity.Property(e => e.IdVeiculo)
                    .HasColumnType("int unsigned")
                    .HasColumnName("ID_VEICULO");

                entity.HasOne(d => d.IdStatusSolicitacaoNavigation)
                    .WithMany(p => p.SolicitacoesManutencao)
                    .HasForeignKey(d => d.IdStatusSolicitacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_SOLICITACOES_MANUTENCAO_STATUS_SOLICITACAO1");

                entity.HasOne(d => d.IdTiposManutencaoNavigation)
                    .WithMany(p => p.SolicitacoesManutencao)
                    .HasForeignKey(d => d.IdTiposManutencao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_SOLICITACOES_MANUTENCAO_TIPOS_MANUTENCAO1");

                entity.HasOne(d => d.IdVeiculoNavigation)
                    .WithMany(p => p.SolicitacoesManutencao)
                    .HasForeignKey(d => d.IdVeiculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_SOLICITACOES_MANUTENCAO_VEICULOS1");
            });

            modelBuilder.Entity<StatusSolicitacao>(entity =>
            {
                entity.ToTable("status_solicitacao");

                entity.Property(e => e.Id)
                    .HasColumnType("int unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("DESCRICAO");
            });

            modelBuilder.Entity<TipoUsuario>(entity =>
            {
                entity.ToTable("tipo_usuario");

                entity.Property(e => e.Id)
                    .HasColumnType("int unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("DESCRICAO");
            });

            modelBuilder.Entity<TiposManutencao>(entity =>
            {
                entity.ToTable("tipos_manutencao");

                entity.HasIndex(e => e.Id, "ID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("DESCRICAO");
            });

            modelBuilder.Entity<Unidade>(entity =>
            {
                entity.ToTable("unidade");

                entity.HasIndex(e => e.Id, "idUnidades_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.Endereco)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("ENDERECO");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("NOME");

                entity.Property(e => e.Sigla)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("SIGLA");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(15)
                    .HasColumnName("TELEFONE");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("usuario");

                entity.HasIndex(e => e.Cpf, "CPF_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.NumeroMatricula, "NUMERO_MATRICULA_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.IdTipoUsuario, "fk_USUARIOS_TIPO_USUARIO1_idx");

                entity.HasIndex(e => e.IdUnidade, "fk_USUARIOS_UNIDADES1_idx");

                entity.Property(e => e.Id)
                    .HasColumnType("int unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("CPF");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.IdTipoUsuario)
                    .HasColumnType("int unsigned")
                    .HasColumnName("ID_TIPO_USUARIO");

                entity.Property(e => e.IdUnidade)
                    .HasColumnType("int unsigned")
                    .HasColumnName("ID_UNIDADE");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NOME");

                entity.Property(e => e.NumeroMatricula)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("NUMERO_MATRICULA");

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("SENHA");

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TELEFONE");

                entity.HasOne(d => d.IdTipoUsuarioNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.IdTipoUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_USUARIOS_TIPO_USUARIO1");

                entity.HasOne(d => d.IdUnidadeNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.IdUnidade)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_USUARIOS_UNIDADES1");
            });

            modelBuilder.Entity<Veiculo>(entity =>
            {
                entity.ToTable("veiculo");

                entity.HasIndex(e => e.IdFrota, "fk_VEICULOS_FROTA1_idx");

                entity.Property(e => e.Id)
                    .HasColumnType("int unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.AnoFabricacao)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("ANO_FABRICACAO");

                entity.Property(e => e.AnoModelo)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("ANO_MODELO");

                entity.Property(e => e.Capacidade).HasColumnName("CAPACIDADE");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("CATEGORIA");

                entity.Property(e => e.Chassi)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CHASSI");

                entity.Property(e => e.Cor)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("COR");

                entity.Property(e => e.DataEmplacamento)
                    .HasColumnType("date")
                    .HasColumnName("DATA_EMPLACAMENTO");

                entity.Property(e => e.IdFrota)
                    .HasColumnType("int unsigned")
                    .HasColumnName("ID_FROTA");

                entity.Property(e => e.LeituraOdômetro).HasColumnName("LEITURA_ODÔMETRO");

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("MARCA");

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("MODELO");

                entity.Property(e => e.NomeclaturaViatura)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("NOMECLATURA_VIATURA");

                entity.Property(e => e.Placa)
                    .IsRequired()
                    .HasMaxLength(7)
                    .HasColumnName("PLACA");

                entity.Property(e => e.Renavam)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("RENAVAM");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.VencimentoIpva)
                    .HasColumnType("date")
                    .HasColumnName("VENCIMENTO_IPVA");

                entity.HasOne(d => d.IdFrotaNavigation)
                    .WithMany(p => p.Veiculo)
                    .HasForeignKey(d => d.IdFrota)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_VEICULOS_FROTA1");
            });

            modelBuilder.Entity<Viagem>(entity =>
            {
                entity.ToTable("viagem");

                entity.HasIndex(e => e.IdMotorista, "fk_VIAGEM_MOTORISTAS1_idx");

                entity.HasIndex(e => e.IdVeiculo, "fk_VIAGEM_VEICULOS1_idx");

                entity.Property(e => e.Id)
                    .HasColumnType("int unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(300)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Destino)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("DESTINO");

                entity.Property(e => e.HorarioChegada).HasColumnName("HORARIO_CHEGADA");

                entity.Property(e => e.HorarioSaida).HasColumnName("HORARIO_SAIDA");

                entity.Property(e => e.IdMotorista)
                    .HasColumnType("int unsigned")
                    .HasColumnName("ID_MOTORISTA");

                entity.Property(e => e.IdVeiculo)
                    .HasColumnType("int unsigned")
                    .HasColumnName("ID_VEICULO");

                entity.Property(e => e.LeituraOdometroFinal)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("LEITURA_ODOMETRO_FINAL");

                entity.Property(e => e.LeituraOdometroInicial)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("LEITURA_ODOMETRO_INICIAL");

                entity.Property(e => e.Origem)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("ORIGEM");

                entity.HasOne(d => d.IdMotoristaNavigation)
                    .WithMany(p => p.Viagem)
                    .HasForeignKey(d => d.IdMotorista)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_VIAGEM_MOTORISTAS1");

                entity.HasOne(d => d.IdVeiculoNavigation)
                    .WithMany(p => p.Viagem)
                    .HasForeignKey(d => d.IdVeiculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_VIAGEM_VEICULOS1");
            });

            modelBuilder.Entity<Vistoria>(entity =>
            {
                entity.ToTable("vistoria");

                entity.HasIndex(e => e.Id, "ID_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.IdRelatorioMecanico, "fk_VISTORIAS_RELATORIO_MECANICO1_idx");

                entity.HasIndex(e => e.IdVeiculo, "fk_VISTORIAS_VEICULOS1_idx");

                entity.Property(e => e.Id)
                    .HasColumnType("int unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.Data)
                    .HasColumnType("date")
                    .HasColumnName("DATA");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.IdRelatorioMecanico).HasColumnName("ID_RELATORIO_MECANICO");

                entity.Property(e => e.IdVeiculo)
                    .HasColumnType("int unsigned")
                    .HasColumnName("ID_VEICULO");

                entity.HasOne(d => d.IdRelatorioMecanicoNavigation)
                    .WithMany(p => p.Vistoria)
                    .HasForeignKey(d => d.IdRelatorioMecanico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_VISTORIAS_RELATORIO_MECANICO1");

                entity.HasOne(d => d.IdVeiculoNavigation)
                    .WithMany(p => p.Vistoria)
                    .HasForeignKey(d => d.IdVeiculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_VISTORIAS_VEICULOS1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
