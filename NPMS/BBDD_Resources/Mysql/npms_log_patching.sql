-- MySQL dump 10.13  Distrib 8.0.17, for Win64 (x86_64)
--
-- Host: localhost    Database: npms
-- ------------------------------------------------------
-- Server version	8.0.17

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `log_patching`
--

DROP TABLE IF EXISTS `log_patching`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `log_patching` (
  `Action` varchar(150) DEFAULT NULL,
  `Building` varchar(45) DEFAULT NULL,
  `Floor` varchar(45) DEFAULT NULL,
  `Closet` varchar(45) DEFAULT NULL,
  `Panel` varchar(45) DEFAULT NULL,
  `Panel_Port` varchar(45) DEFAULT NULL,
  `Stack` varchar(45) DEFAULT NULL,
  `Switch` varchar(45) DEFAULT NULL,
  `Switch_Port` varchar(45) DEFAULT NULL,
  `Interfaz` varchar(45) DEFAULT NULL,
  `Link` varchar(45) DEFAULT NULL,
  `Speed` varchar(45) DEFAULT NULL,
  `Duplex` varchar(45) DEFAULT NULL,
  `Type` varchar(45) DEFAULT NULL,
  `Vlan` varchar(45) DEFAULT NULL,
  `Description` varchar(45) DEFAULT NULL,
  `IP_Switch` varchar(45) DEFAULT NULL,
  `User` varchar(150) DEFAULT NULL,
  `WORK_ORDER` varchar(150) DEFAULT NULL,
  `Date` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `log_patching`
--

LOCK TABLES `log_patching` WRITE;
/*!40000 ALTER TABLE `log_patching` DISABLE KEYS */;
/*!40000 ALTER TABLE `log_patching` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-03-21 18:28:03
