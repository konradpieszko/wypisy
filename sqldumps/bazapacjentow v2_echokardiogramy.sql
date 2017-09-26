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
-- Table structure for table `echokardiogramy`
--

DROP TABLE IF EXISTS `echokardiogramy`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `echokardiogramy` (
  `EchoID` int(11) NOT NULL AUTO_INCREMENT,
  `PESEL` varchar(45) DEFAULT NULL,
  `NumKG` varchar(45) DEFAULT NULL,
  `DataBadania` varchar(45) DEFAULT NULL,
  `LA` varchar(45) DEFAULT NULL,
  `LV` varchar(45) DEFAULT NULL,
  `Ao` varchar(45) DEFAULT NULL,
  `RV` varchar(45) DEFAULT NULL,
  `IVS` varchar(45) DEFAULT NULL,
  `PW` varchar(45) DEFAULT NULL,
  `Act` varchar(45) DEFAULT NULL,
  `MitrMorf` varchar(45) DEFAULT NULL,
  `MitrCzynn` varchar(45) DEFAULT NULL,
  `AoMorf` varchar(45) DEFAULT NULL,
  `AoCzynn` varchar(45) DEFAULT NULL,
  `Trojdzielna` varchar(45) DEFAULT NULL,
  `Kurczliwość` varchar(45) DEFAULT NULL,
  `EF` varchar(45) DEFAULT NULL,
  `Rozkurcz` varchar(45) DEFAULT NULL,
  `E` varchar(45) DEFAULT NULL,
  `A` varchar(45) DEFAULT NULL,
  `Eprim` varchar(45) DEFAULT NULL,
  `Aprim` varchar(45) DEFAULT NULL,
  `TekstEcho` varchar(45) DEFAULT NULL,
  `LekID` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`EchoID`)
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
