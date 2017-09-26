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
-- Table structure for table `badania_laboratoryjne`
--

DROP TABLE IF EXISTS `badania_laboratoryjne`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `badania_laboratoryjne` (
  `BadanieID` int(10) NOT NULL AUTO_INCREMENT,
  `PESEL` varchar(255) DEFAULT NULL,
  `Nazwa Badania` varchar(255) DEFAULT NULL,
  `Data_badania` datetime DEFAULT NULL,
  `Wynik` varchar(255) DEFAULT NULL,
  `Zakres` varchar(255) DEFAULT NULL,
  `Jednostka` varchar(255) DEFAULT NULL,
  `NumKg` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`BadanieID`),
  UNIQUE KEY `BadanieID_UNIQUE` (`BadanieID`),
  KEY `BadanieID` (`BadanieID`),
  KEY `PacjenciBadania_Laboratoryjne` (`PESEL`),
  KEY `NumKg` (`NumKg`),
  KEY `nazwa` (`Nazwa Badania`),
  CONSTRAINT `PacjenciBadania_Laboratoryjne` FOREIGN KEY (`PESEL`) REFERENCES `pacjenci` (`PESEL`)
) ENGINE=InnoDB AUTO_INCREMENT=1813101 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-09-26  2:00:06
