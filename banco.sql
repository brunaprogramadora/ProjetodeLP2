-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           5.5.5-10.0.14-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              8.3.0.4694
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Copiando estrutura do banco de dados para produto
CREATE DATABASE IF NOT EXISTS `produto` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `produto`;


-- Copiando estrutura para tabela produto.produto
CREATE TABLE IF NOT EXISTS `produto` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Nome` text NOT NULL,
  `Funcionalidade` text NOT NULL,
  `Validade` text NOT NULL,
  `Origem` text NOT NULL,
  `Quantidade` text NOT NULL,
  `Descricao` text NOT NULL,
  `Localizacao` text NOT NULL,
  `Marca` text NOT NULL,
  `FaixaEtaria` text NOT NULL,
  `Textura` text NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela produto.produto: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `produto` DISABLE KEYS */;
INSERT INTO `produto` (`Id`, `Nome`, `Funcionalidade`, `Validade`, `Origem`, `Quantidade`, `Descricao`, `Localizacao`, `Marca`, `FaixaEtaria`, `Textura`) VALUES
	(1, 'ff', 'ff', 'ff', 'ff', 'fff', 'ff', 'ff', 'ff', 'ff', 'ffff'),
	(2, 'gg', 'gg', 'gg', 'gg', 'gg', 'gg', 'gg', 'gg', 'gg', 'gg');
/*!40000 ALTER TABLE `produto` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
