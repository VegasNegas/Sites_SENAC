-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Tempo de geração: 09-Mar-2021 às 01:17
-- Versão do servidor: 8.0.21
-- versão do PHP: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `login`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `pacoteturistico`
--

DROP TABLE IF EXISTS `pacoteturistico`;
CREATE TABLE IF NOT EXISTS `pacoteturistico` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(30) DEFAULT NULL,
  `Origem` varchar(50) DEFAULT NULL,
  `Destino` varchar(50) DEFAULT NULL,
  `Atrativo` varchar(50) DEFAULT NULL,
  `Saida` date DEFAULT NULL,
  `Retorno` date DEFAULT NULL,
  `Usuario` int DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `Usuario` (`Usuario`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `pacoteturistico`
--

INSERT INTO `pacoteturistico` (`Id`, `Nome`, `Origem`, `Destino`, `Atrativo`, `Saida`, `Retorno`, `Usuario`) VALUES
(2, 'dasdasdasdasd', 'asdasdasasd', 'asdasdasdasdas', 'dasdasd', '2021-03-25', '2021-03-31', 0),
(3, 'seila', 'seila', 'seila', 'seila', '2021-03-26', '2021-03-31', 5),
(4, 'seila', 'seila', 'seila', 'seila', '2021-03-26', '2021-03-31', 5),
(5, 'casa', 'sela', 'seila', 'seila', '2021-03-18', '2021-03-24', 5),
(8, 'dasdasd', 'asdasdasd', 'sdasdasd', 'asdasdasd', '2021-03-22', '2021-03-24', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE IF NOT EXISTS `usuario` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(30) DEFAULT NULL,
  `Login` varchar(30) DEFAULT NULL,
  `Senha` varchar(30) DEFAULT NULL,
  `DataNascimento` date DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`Id`, `Nome`, `Login`, `Senha`, `DataNascimento`) VALUES
(1, 'user', 'user', 'user', NULL),
(3, 'user2', 'user2', 'user2', '2021-03-09'),
(5, 'user3', 'user3', 'user3', '2021-03-16');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
