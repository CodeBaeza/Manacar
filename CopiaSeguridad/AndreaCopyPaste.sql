-- MySqlBackup.NET 2.3.4
-- Dump Time: 2021-05-30 18:00:23
-- --------------------------------------
-- Server version 10.4.18-MariaDB mariadb.org binary distribution


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of clientes
-- 

DROP TABLE IF EXISTS `clientes`;
CREATE TABLE IF NOT EXISTS `clientes` (
  `nombre` varchar(50) NOT NULL,
  `apellidos` varchar(50) NOT NULL,
  `dni` varchar(50) NOT NULL,
  `fecha_entrada` datetime(6) NOT NULL,
  `fecha_salida` datetime(6) NOT NULL,
  `matricula` varchar(10) NOT NULL,
  `marca` varchar(10) NOT NULL,
  `modelo` varchar(10) NOT NULL,
  `plaza_parking` varchar(10) NOT NULL,
  PRIMARY KEY (`dni`),
  UNIQUE KEY `matricula` (`matricula`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 
-- Dumping data for table clientes
-- 

/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes`(`nombre`,`apellidos`,`dni`,`fecha_entrada`,`fecha_salida`,`matricula`,`marca`,`modelo`,`plaza_parking`) VALUES
('Laura','Torrijos','03450432M','0001-01-01 00:00:00.000000','0001-01-01 00:00:00.000000','Mercedes','6789IKJ','Benz','222'),
('1','1','1','2021-07-10 00:00:00.000000','2021-07-23 00:00:00.000000','1','1','','1'),
('Javier','Granero','123321453T','0001-01-01 00:00:00.000000','0001-01-01 00:00:00.000000','3434FGG','BMW','M5','455'),
('Andrea','andreita','123456789a','0001-01-01 00:00:00.000000','0001-01-01 00:00:00.000000','2323qwe','bugatti','veiron','12'),
('Mari','Junior','231234f','0001-01-01 00:00:00.000000','0001-01-01 00:00:00.000000','3456ert','mercedes','','789'),
('Rafa ','Granero','23454321Q','0001-01-01 00:00:00.000000','0001-01-01 00:00:00.000000','4444hhh','VolksWagen','golf','98'),
('bbbbbbbbbbbb','bbbbbbbb','bbbbbbbbbbbbbbbbbb','0001-01-01 00:00:00.000000','0001-01-01 00:00:00.000000','bbbbb','bbbbbbbb','bbbbbbbb','bbbbbbbbbb'),
('f','f','f','0001-01-01 00:00:00.000000','0001-01-01 00:00:00.000000','f','f','f',''),
('fdfd','dfd','fdfd','0001-01-01 00:00:00.000000','0001-01-01 00:00:00.000000','','','',''),
('g','g','g','0001-01-01 00:00:00.000000','0001-01-01 00:00:00.000000','g','g','g','g'),
('Cristian','Baeza ','Garcia','2021-05-26 11:48:39.000000','2021-05-29 11:48:42.000000','1234qwe','bugatti','veiron','234'),
('r','r','r','0001-01-01 00:00:00.000000','0001-01-01 00:00:00.000000','r','r','r','r'),
('xxxxxxxxxx','xxxxxxxxxxx','xxxxxxxxxxxxxxx','0001-01-01 00:00:00.000000','0001-01-01 00:00:00.000000','xxxxxxxxx','xxxxxxxx','xxxxxxxxxx','xxxxxxxxxx');
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;

-- 
-- Definition of usuarios
-- 

DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE IF NOT EXISTS `usuarios` (
  `usuario` varchar(50) NOT NULL,
  `contraseña` varchar(50) NOT NULL,
  PRIMARY KEY (`usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 
-- Dumping data for table usuarios
-- 

/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios`(`usuario`,`contraseña`) VALUES
('1','1'),
('Cristian','123'),
('Laura','Laura');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2021-05-30 18:00:23
-- Total time: 0:0:0:0:134 (d:h:m:s:ms)
