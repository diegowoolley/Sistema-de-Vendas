-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 13/01/2024 às 18:28
-- Versão do servidor: 10.4.32-MariaDB
-- Versão do PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `dbsistema_vendas`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `cad_usuarios`
--

CREATE TABLE `cad_usuarios` (
  `cod_Usuarios` int(200) NOT NULL,
  `nome_usuarios` varchar(200) NOT NULL,
  `senha_Usuarios` varchar(200) NOT NULL,
  `permissoes_Usuarios` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `cad_usuarios`
--

INSERT INTO `cad_usuarios` (`cod_Usuarios`, `nome_usuarios`, `senha_Usuarios`, `permissoes_Usuarios`) VALUES
(1, 'DIEGO', '1234', 'Administrador'),
(2, 'ALINE', '1234', 'Administrador');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `cad_usuarios`
--
ALTER TABLE `cad_usuarios`
  ADD PRIMARY KEY (`cod_Usuarios`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cad_usuarios`
--
ALTER TABLE `cad_usuarios`
  MODIFY `cod_Usuarios` int(200) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
