CREATE DATABASE  IF NOT EXISTS `best_restaurants` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `best_restaurants`;
-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: localhost    Database: best_restaurants
-- ------------------------------------------------------
-- Server version	8.0.19

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
-- Table structure for table `cuisines`
--

DROP TABLE IF EXISTS `cuisines`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cuisines` (
  `cuisineId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  `Region` varchar(45) NOT NULL DEFAULT 'n/a',
  PRIMARY KEY (`cuisineId`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cuisines`
--

LOCK TABLES `cuisines` WRITE;
/*!40000 ALTER TABLE `cuisines` DISABLE KEYS */;
INSERT INTO `cuisines` VALUES (1,'Americana','U.S.A'),(2,'Cajun','Louisiana'),(3,'Sushi','Japan'),(4,'Italian (Traditional)','Italy'),(5,'Pizza','Italy'),(6,'TexMex','Southern U.S.A.'),(7,'Mexican (Traditional)','Mexico'),(8,'Mexican (Modern)','U.S.A.'),(9,'Ethiopian','Ethiopia'),(10,'Korean','South Korea'),(11,'Ramen','Japan'),(12,'Curry','India'),(13,'Bao','Japan'),(14,'Japanese (Traditional)','Japan'),(15,'French (classical)','France'),(16,'Latvian','Latvia'),(17,'Chinese (American)','U.S.A.'),(18,'Chinese (Traditional)','U.S.A.'),(19,'Vietnamese','Vietnam'),(20,'Nepalese','Nepal'),(21,'German','Germany'),(22,'Irish','Ireland'),(23,'Thai','Taiwan'),(24,'Peruvian','Peru'),(25,'Polish','Poland'),(26,'Greek','Greece'),(27,'English (Traditional)','U.K.'),(28,'hawaiian','Hawaii'),(29,'Fusion','n/a'),(30,'Other','n/a');
/*!40000 ALTER TABLE `cuisines` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ratings`
--

DROP TABLE IF EXISTS `ratings`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ratings` (
  `ratingId` int NOT NULL AUTO_INCREMENT,
  `restaurantId` int NOT NULL,
  `Score` decimal(10,0) NOT NULL DEFAULT '0',
  `Review` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ratingId`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ratings`
--

LOCK TABLES `ratings` WRITE;
/*!40000 ALTER TABLE `ratings` DISABLE KEYS */;
/*!40000 ALTER TABLE `ratings` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `restaurants`
--

DROP TABLE IF EXISTS `restaurants`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `restaurants` (
  `restaurantId` int NOT NULL AUTO_INCREMENT,
  `cuisineId` int NOT NULL,
  `Name` varchar(45) NOT NULL,
  `Location` varchar(45) NOT NULL DEFAULT 'n/a',
  `PhoneNumber` varchar(45) NOT NULL DEFAULT 'n/a',
  `Rating` int NOT NULL DEFAULT '0',
  PRIMARY KEY (`restaurantId`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `restaurants`
--

LOCK TABLES `restaurants` WRITE;
/*!40000 ALTER TABLE `restaurants` DISABLE KEYS */;
/*!40000 ALTER TABLE `restaurants` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-07-30 17:20:58
