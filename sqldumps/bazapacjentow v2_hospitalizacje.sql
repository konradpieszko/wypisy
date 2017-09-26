-- MySQL dump 10.13  Distrib 5.7.12, for Win32 (AMD64)
--
-- Host: localhost    Database: bazapacjentow v2
-- ------------------------------------------------------
-- Server version	5.7.17-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `hospitalizacje`
--

DROP TABLE IF EXISTS `hospitalizacje`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hospitalizacje` (
  `NumKg` varchar(255) NOT NULL,
  `PESEL_Pacjenta` varchar(255) DEFAULT NULL,
  `Rozpoznanie_Glowne` varchar(45) DEFAULT NULL,
  `Data_Przyjecia` datetime DEFAULT NULL,
  `Data_Wypisu` datetime DEFAULT NULL,
  `Zgon` tinyint(1) NOT NULL,
  `Epikryza` longtext,
  `Wypis_Plik` longtext,
  `Lekarz_ID` int(11) DEFAULT NULL,
  `Koronarografia` int(11) DEFAULT NULL,
  `Koronaroplastyka` int(11) DEFAULT NULL,
  `powiazano` int(11) DEFAULT NULL,
  `rehabilitacja` int(11) DEFAULT NULL,
  `ink` int(11) DEFAULT NULL,
  `kardiologia` int(11) DEFAULT NULL,
  PRIMARY KEY (`NumKg`),
  KEY `PacjenciHospitalizacje` (`PESEL_Pacjenta`),
  KEY `NumKg` (`NumKg`),
  CONSTRAINT `PacjenciHospitalizacje` FOREIGN KEY (`PESEL_Pacjenta`) REFERENCES `pacjenci` (`PESEL`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-09-26  2:00:07
