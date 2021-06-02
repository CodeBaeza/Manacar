-- MySqlBackup.NET 2.3.4
-- Dump Time: 2021-06-02 13:12:18
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
('Cristian','Baeza','02307468Q','2021-07-21 00:00:00.000000','2021-06-25 00:00:00.000000','7412GHG','Bugatti','Veiron','9'),
('David','Martinez Caballero','20321457L','2021-07-21 00:00:00.000000','2021-05-29 00:00:00.000000','8574FGH','Opel','Astra','23'),
('Laura','Torrijos','2456741M','2021-07-29 00:00:00.000000','2021-08-19 00:00:00.000000','4563KKJ','Lamborgini','Diablo','7'),
('Jose Luis','Baeza Segovia','43562312Q','2021-06-24 00:00:00.000000','2021-06-26 00:00:00.000000','4534TGB','Audi','','8'),
('Merida','Sanz Gomez','56455432L','2021-08-06 00:00:00.000000','2021-08-07 00:00:00.000000','9098TGB','SEAT','LEON','14'),
('Miriam','Martinez Saez','74124569G','2021-07-10 00:00:00.000000','2021-07-11 00:00:00.000000','4563WWE','SEAT','IBIZA','11'),
('Hector','Muñiz Marcos','89564123F','2021-06-02 00:00:00.000000','2021-06-05 00:00:00.000000','4567TYU','Mazda','RX8','12'),
('Angel','Cilleruelo','89675634G','2021-07-08 00:00:00.000000','2021-06-17 00:00:00.000000','5689','Ford','Mustang','34');
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
('Angel','123'),
('Cristian','123'),
('Jose','123'),
('Laura','Laura');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2021-06-02 13:12:18
-- Total time: 0:0:0:0:64 (d:h:m:s:ms)
