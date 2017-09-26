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
-- Temporary view structure for view `biezace`
--

DROP TABLE IF EXISTS `biezace`;
/*!50001 DROP VIEW IF EXISTS `biezace`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `biezace` AS SELECT 
 1 AS `imie_i_nazwisko`,
 1 AS `NumKg`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `powiazane_wypisy`
--

DROP TABLE IF EXISTS `powiazane_wypisy`;
/*!50001 DROP VIEW IF EXISTS `powiazane_wypisy`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `powiazane_wypisy` AS SELECT 
 1 AS `NumKg`,
 1 AS `PESEL`,
 1 AS `Imie`,
 1 AS `Nazwisko`,
 1 AS `Data_Przyjecia`,
 1 AS `Rozpoznanie_Glowne`,
 1 AS `rehabilitacja`,
 1 AS `kardiologia`,
 1 AS `ink`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `badania_ozw`
--

DROP TABLE IF EXISTS `badania_ozw`;
/*!50001 DROP VIEW IF EXISTS `badania_ozw`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `badania_ozw` AS SELECT 
 1 AS `NKG`,
 1 AS `neu`,
 1 AS `kr`,
 1 AS `lymb`,
 1 AS `plt`,
 1 AS `rdw`,
 1 AS `eosp`,
 1 AS `monob`,
 1 AS `basob`,
 1 AS `hgb`,
 1 AS `hct`,
 1 AS `mcv`,
 1 AS `mpv`,
 1 AS `crp`,
 1 AS `na`,
 1 AS `k`,
 1 AS `ldl`,
 1 AS `hdl`,
 1 AS `trg`,
 1 AS `chol`,
 1 AS `hba1c`,
 1 AS `ur`,
 1 AS `inr`,
 1 AS `aptt`,
 1 AS `pt`,
 1 AS `tt`,
 1 AS `fib`,
 1 AS `tsh`,
 1 AS `ast`,
 1 AS `alt`,
 1 AS `gfr`,
 1 AS `trot`,
 1 AS `tro`,
 1 AS `wiek`,
 1 AS `Plec`,
 1 AS `kontrast`,
 1 AS `dawka`,
 1 AS `pobyt`,
 1 AS `Koronaroplastyka`,
 1 AS `Rozpoznanie_Glowne`,
 1 AS `rehabilitacja`,
 1 AS `powiazano`,
 1 AS `Wypis_Plik`,
 1 AS `PESEL_Pacjenta`,
 1 AS `Data_Przyjecia`,
 1 AS `Data_Wypisu`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `wypisy_rozp`
--

DROP TABLE IF EXISTS `wypisy_rozp`;
/*!50001 DROP VIEW IF EXISTS `wypisy_rozp`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `wypisy_rozp` AS SELECT 
 1 AS `NumKg`,
 1 AS `PESEL`,
 1 AS `Imie`,
 1 AS `Nazwisko`,
 1 AS `Data_Przyjecia`,
 1 AS `Rozpoznanie_Glowne`,
 1 AS `rehabilitacja`,
 1 AS `kardiologia`,
 1 AS `ink`,
 1 AS `Wypis_Plik`,
 1 AS `ilosc_rozpoznan`,
 1 AS `N`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `niepowiazane_wypisy`
--

DROP TABLE IF EXISTS `niepowiazane_wypisy`;
/*!50001 DROP VIEW IF EXISTS `niepowiazane_wypisy`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `niepowiazane_wypisy` AS SELECT 
 1 AS `NumKg`,
 1 AS `PESEL`,
 1 AS `Imie`,
 1 AS `Nazwisko`,
 1 AS `Data_Przyjecia`,
 1 AS `Rozpoznanie_Glowne`,
 1 AS `rehabilitacja`,
 1 AS `kardiologia`,
 1 AS `ink`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `biezace`
--

/*!50001 DROP VIEW IF EXISTS `biezace`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`Konrad`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `biezace` AS select concat(`pacjenci`.`Imie`,' ',`pacjenci`.`Nazwisko`) AS `imie_i_nazwisko`,`hosp`.`NumKg` AS `NumKg` from ((`biezace_wypisy` `wyp` left join `hospitalizacje` `hosp` on((`wyp`.`NumKg` = `hosp`.`NumKg`))) left join `pacjenci` on((`pacjenci`.`PESEL` = `hosp`.`PESEL_Pacjenta`))) order by `wyp`.`data_dodania` desc */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `powiazane_wypisy`
--

/*!50001 DROP VIEW IF EXISTS `powiazane_wypisy`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`Konrad`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `powiazane_wypisy` AS select `hospitalizacje`.`NumKg` AS `NumKg`,`pacjenci`.`PESEL` AS `PESEL`,`pacjenci`.`Imie` AS `Imie`,`pacjenci`.`Nazwisko` AS `Nazwisko`,`hospitalizacje`.`Data_Przyjecia` AS `Data_Przyjecia`,`hospitalizacje`.`Rozpoznanie_Glowne` AS `Rozpoznanie_Glowne`,`hospitalizacje`.`rehabilitacja` AS `rehabilitacja`,`hospitalizacje`.`kardiologia` AS `kardiologia`,`hospitalizacje`.`ink` AS `ink` from (`hospitalizacje` left join `pacjenci` on((`hospitalizacje`.`PESEL_Pacjenta` = `pacjenci`.`PESEL`))) where (`hospitalizacje`.`powiazano` is not null) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `badania_ozw`
--

/*!50001 DROP VIEW IF EXISTS `badania_ozw`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`Konrad`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `badania_ozw` AS select `hosp`.`NumKg` AS `NKG`,(select cast(`badania_laboratoryjne`.`Wynik` as decimal(10,3)) from `badania_laboratoryjne` where ((`badania_laboratoryjne`.`Nazwa Badania` = 'NEU') and (`badania_laboratoryjne`.`NumKg` = `hosp`.`NumKg`)) order by `badania_laboratoryjne`.`Data_badania` limit 1) AS `neu`,(select cast(`badania_laboratoryjne`.`Wynik` as decimal(10,3)) from `badania_laboratoryjne` where ((`badania_laboratoryjne`.`Nazwa Badania` = 'KR') and (`badania_laboratoryjne`.`NumKg` = `hosp`.`NumKg`)) order by `badania_laboratoryjne`.`Data_badania` limit 1) AS `kr`,(select cast(`badania_laboratoryjne`.`Wynik` as decimal(10,3)) from `badania_laboratoryjne` where ((`badania_laboratoryjne`.`Nazwa Badania` = 'LYMB') and (`badania_laboratoryjne`.`NumKg` = `hosp`.`NumKg`)) order by `badania_laboratoryjne`.`Data_badania` limit 1) AS `lymb`,(select cast(`badania_laboratoryjne`.`Wynik` as decimal(10,3)) from `badania_laboratoryjne` where ((`badania_laboratoryjne`.`Nazwa Badania` = 'PLT') and (`badania_laboratoryjne`.`NumKg` = `hosp`.`NumKg`)) order by `badania_laboratoryjne`.`Data_badania` limit 1) AS `plt`,(select cast(`badania_laboratoryjne`.`Wynik` as decimal(10,3)) from `badania_laboratoryjne` where ((`badania_laboratoryjne`.`Nazwa Badania` = 'RDW') and (`badania_laboratoryjne`.`NumKg` = `hosp`.`NumKg`)) order by `badania_laboratoryjne`.`Data_badania` limit 1) AS `rdw`,(select cast(`badania_laboratoryjne`.`Wynik` as decimal(10,3)) from `badania_laboratoryjne` where ((`badania_laboratoryjne`.`Nazwa Badania` = 'EOSB') and (`badania_laboratoryjne`.`NumKg` = `hosp`.`NumKg`)) order by `badania_laboratoryjne`.`Data_badania` limit 1) AS `eosp`,(select cast(`badania_laboratoryjne`.`Wynik` as decimal(10,3)) from `badania_laboratoryjne` where ((`badania_laboratoryjne`.`Nazwa Badania` = 'MONOB') and (`badania_laboratoryjne`.`NumKg` = `hosp`.`NumKg`)) order by `badania_laboratoryjne`.`Data_badania` limit 1) AS `monob`,(select cast(`badania_laboratoryjne`.`Wynik` as decimal(10,3)) from `badania_laboratoryjne` where ((`badania_laboratoryjne`.`Nazwa Badania` = 'BASOB') and (`badania_laboratoryjne`.`NumKg` = `hosp`.`NumKg`)) order by `badania_laboratoryjne`.`Data_badania` limit 1) AS `basob`,(select cast(`badania_laboratoryjne`.`Wynik` as decimal(10,3)) from `badania_laboratoryjne` where ((`badania_laboratoryjne`.`Nazwa Badania` = 'HGB') and (`badania_laboratoryjne`.`NumKg` = `hosp`.`NumKg`)) order by `badania_laboratoryjne`.`Data_badania` limit 1) AS `hgb`,(select cast(`badania_laboratoryjne`.`Wynik` as decimal(10,3)) from `badania_laboratoryjne` where ((`badania_laboratoryjne`.`Nazwa Badania` = 'HCT') and (`badania_laboratoryjne`.`NumKg` = `hosp`.`NumKg`)) order by `badania_laboratoryjne`.`Data_badania` limit 1) AS `hct`,(select cast(`badania_laboratoryjne`.`Wynik` as decimal(10,3)) from `badania_laboratoryjne` where ((`badania_laboratoryjne`.`Nazwa Badania` = 'MCV') and (`badania_laboratoryjne`.`NumKg` = `hosp`.`NumKg`)) order by `badania_laboratoryjne`.`Data_badania` limit 1) AS `mcv`,(select cast(`badania_laboratoryjne`.`Wynik` as decimal(10,3)) from `badania_laboratoryjne` where ((`badania_laboratoryjne`.`Nazwa Badania` = 'MPV') and (`badania_laboratoryjne`.`NumKg` = `hosp`.`NumKg`)) order by `badania_laboratoryjne`.`Data_badania` limit 1) AS `mpv`,(select cast(`badania_laboratoryjne`.`Wynik` as decimal(10,3)) from `badania_laboratoryjne` where ((`badania_laboratoryjne`.`Nazwa Badania` = 'CRP') and (`badania_laboratoryjne`.`NumKg` = `hosp`.`NumKg`)) order by `badania_laboratoryjne`.`Data_badania` limit 1) AS `crp`,(select cast(`badania_laboratoryjne`.`Wynik` as decimal(10,3)) from `badania_laboratoryjne` where ((`badania_laboratoryjne`.`Nazwa Badania` = 'NA') and (`badania_laboratoryjne`.`NumKg` = `hosp`.`NumKg`)) order by `badania_laboratoryjne`.`Data_badania` limit 1) AS `na`,(select cast(`badania_laboratoryjne`.`Wynik` as decimal(10,3)) from `badania_laboratoryjne` where ((`badania_laboratoryjne`.`Nazwa Badania` = 'K') and (`badania_laboratoryjne`.`NumKg` = `hosp`.`NumKg`)) order by `badania_laboratoryjne`.`Data_badania` limit 1) AS `k`,(select cast(`badania_laboratoryjne`.`Wynik` as decimal(10,3)) from `badania_laboratoryjne` where ((`badania_laboratoryjne`.`Nazwa Badania` = 'LDL') and (`badania_laboratoryjne`.`NumKg` = `hosp`.`NumKg`)) order by `badania_laboratoryjne`.`Data_badania` limit 1) AS `ldl`,(select cast(`badania_laboratoryjne`.`Wynik` as decimal(10,3)) from `badania_laboratoryjne` where ((`badania_laboratoryjne`.`Nazwa Badania` = 'HDL') and (`badania_laboratoryjne`.`NumKg` = `hosp`.`NumKg`)) order by `badania_laboratoryjne`.`Data_badania` limit 1) AS `hdl`,(select cast(`badania_laboratoryjne`.`Wynik` as decimal(10,3)) from `badania_laboratoryjne` where ((`badania_laboratoryjne`.`Nazwa Badania` = 'TRG') and (`badania_laboratoryjne`.`NumKg` = `hosp`.`NumKg`)) order by `badania_laboratoryjne`.`Data_badania` limit 1) AS `trg`,(select cast(`badania_laboratoryjne`.`Wynik` as decimal(10,3)) from `badania_laboratoryjne` where ((`badania_laboratoryjne`.`Nazwa Badania` = 'CHOL') and (`badania_laboratoryjne`.`NumKg` = `hosp`.`NumKg`)) order by `badania_laboratoryjne`.`Data_badania` limit 1) AS `chol`,(select cast(`badania_laboratoryjne`.`Wynik` as decimal(10,3)) from `badania_laboratoryjne` where ((`badania_laboratoryjne`.`Nazwa Badania` = 'HBA1C') and (`badania_laboratoryjne`.`NumKg` = `hosp`.`NumKg`)) order by `badania_laboratoryjne`.`Data_badania` limit 1) AS `hba1c`,(select cast(`badania_laboratoryjne`.`Wynik` as decimal(10,3)) from `badania_laboratoryjne` where ((`badania_laboratoryjne`.`Nazwa Badania` = 'UR') and (`badania_laboratoryjne`.`NumKg` = `hosp`.`NumKg`)) order by `badania_laboratoryjne`.`Data_badania` limit 1) AS `ur`,(select cast(`badania_laboratoryjne`.`Wynik` as decimal(10,3)) from `badania_laboratoryjne` where ((`badania_laboratoryjne`.`Nazwa Badania` = 'INR') and (`badania_laboratoryjne`.`NumKg` = `hosp`.`NumKg`)) order by `badania_laboratoryjne`.`Data_badania` limit 1) AS `inr`,(select cast(`badania_laboratoryjne`.`Wynik` as decimal(10,3)) from `badania_laboratoryjne` where ((`badania_laboratoryjne`.`Nazwa Badania` = 'APTT') and (`badania_laboratoryjne`.`NumKg` = `hosp`.`NumKg`)) order by `badania_laboratoryjne`.`Data_badania` limit 1) AS `aptt`,(select cast(`badania_laboratoryjne`.`Wynik` as decimal(10,3)) from `badania_laboratoryjne` where ((`badania_laboratoryjne`.`Nazwa Badania` = 'PT') and (`badania_laboratoryjne`.`NumKg` = `hosp`.`NumKg`)) order by `badania_laboratoryjne`.`Data_badania` limit 1) AS `pt`,(select cast(`badania_laboratoryjne`.`Wynik` as decimal(10,3)) from `badania_laboratoryjne` where ((`badania_laboratoryjne`.`Nazwa Badania` = 'TT') and (`badania_laboratoryjne`.`NumKg` = `hosp`.`NumKg`)) order by `badania_laboratoryjne`.`Data_badania` limit 1) AS `tt`,(select cast(`badania_laboratoryjne`.`Wynik` as decimal(10,3)) from `badania_laboratoryjne` where ((`badania_laboratoryjne`.`Nazwa Badania` = 'FIB') and (`badania_laboratoryjne`.`NumKg` = `hosp`.`NumKg`)) order by `badania_laboratoryjne`.`Data_badania` limit 1) AS `fib`,(select cast(`badania_laboratoryjne`.`Wynik` as decimal(10,3)) from `badania_laboratoryjne` where ((`badania_laboratoryjne`.`Nazwa Badania` = 'TSH') and (`badania_laboratoryjne`.`NumKg` = `hosp`.`NumKg`)) order by `badania_laboratoryjne`.`Data_badania` limit 1) AS `tsh`,(select cast(`badania_laboratoryjne`.`Wynik` as decimal(10,3)) from `badania_laboratoryjne` where ((`badania_laboratoryjne`.`Nazwa Badania` = 'AST') and (`badania_laboratoryjne`.`NumKg` = `hosp`.`NumKg`)) order by `badania_laboratoryjne`.`Data_badania` limit 1) AS `ast`,(select cast(`badania_laboratoryjne`.`Wynik` as decimal(10,3)) from `badania_laboratoryjne` where ((`badania_laboratoryjne`.`Nazwa Badania` = 'ALT') and (`badania_laboratoryjne`.`NumKg` = `hosp`.`NumKg`)) order by `badania_laboratoryjne`.`Data_badania` limit 1) AS `alt`,(select cast(`badania_laboratoryjne`.`Wynik` as decimal(10,3)) from `badania_laboratoryjne` where ((`badania_laboratoryjne`.`Nazwa Badania` = 'GFR') and (`badania_laboratoryjne`.`NumKg` = `hosp`.`NumKg`)) order by `badania_laboratoryjne`.`Data_badania` limit 1) AS `gfr`,(select cast(`badania_laboratoryjne`.`Wynik` as decimal(10,3)) from `badania_laboratoryjne` where ((`badania_laboratoryjne`.`Nazwa Badania` = 'TROT') and (`badania_laboratoryjne`.`NumKg` = `hosp`.`NumKg`)) order by `badania_laboratoryjne`.`Data_badania` limit 1) AS `trot`,(select cast(`badania_laboratoryjne`.`Wynik` as decimal(10,3)) from `badania_laboratoryjne` where ((`badania_laboratoryjne`.`Nazwa Badania` = 'TRO') and (`badania_laboratoryjne`.`NumKg` = `hosp`.`NumKg`)) order by `badania_laboratoryjne`.`Data_badania` limit 1) AS `tro`,((to_days(`hosp`.`Data_Przyjecia`) - to_days(str_to_date(concat('19',substr(`hosp`.`PESEL_Pacjenta`,1,6)),'%Y%m%d'))) / 365) AS `wiek`,`pacjenci`.`Plec` AS `Plec`,`koro`.`ObjKontr` AS `kontrast`,`koro`.`DawkaProm` AS `dawka`,(to_days(`hosp`.`Data_Wypisu`) - to_days(`hosp`.`Data_Przyjecia`)) AS `pobyt`,`hosp`.`Koronaroplastyka` AS `Koronaroplastyka`,`hosp`.`Rozpoznanie_Glowne` AS `Rozpoznanie_Glowne`,`hosp`.`rehabilitacja` AS `rehabilitacja`,`hosp`.`powiazano` AS `powiazano`,`hosp`.`Wypis_Plik` AS `Wypis_Plik`,`hosp`.`PESEL_Pacjenta` AS `PESEL_Pacjenta`,`hosp`.`Data_Przyjecia` AS `Data_Przyjecia`,`hosp`.`Data_Wypisu` AS `Data_Wypisu` from ((`hospitalizacje` `hosp` left join `pacjenci` on((`hosp`.`PESEL_Pacjenta` = `pacjenci`.`PESEL`))) left join `koronarografie` `koro` on((`hosp`.`NumKg` = `koro`.`NumKG`))) group by `NKG` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `wypisy_rozp`
--

/*!50001 DROP VIEW IF EXISTS `wypisy_rozp`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`Konrad`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `wypisy_rozp` AS select `powiazane_wypisy`.`NumKg` AS `NumKg`,`powiazane_wypisy`.`PESEL` AS `PESEL`,`powiazane_wypisy`.`Imie` AS `Imie`,`powiazane_wypisy`.`Nazwisko` AS `Nazwisko`,`powiazane_wypisy`.`Data_Przyjecia` AS `Data_Przyjecia`,`powiazane_wypisy`.`Rozpoznanie_Glowne` AS `Rozpoznanie_Glowne`,`powiazane_wypisy`.`rehabilitacja` AS `rehabilitacja`,`powiazane_wypisy`.`kardiologia` AS `kardiologia`,`powiazane_wypisy`.`ink` AS `ink`,`powiazane_wypisy`.`Wypis_Plik` AS `Wypis_Plik`,`sel`.`ilosc_rozpoznan` AS `ilosc_rozpoznan`,`sel`.`N` AS `N` from (((select `bazapacjentow v2`.`hospitalizacje`.`NumKg` AS `NumKg`,`bazapacjentow v2`.`pacjenci`.`PESEL` AS `PESEL`,`bazapacjentow v2`.`pacjenci`.`Imie` AS `Imie`,`bazapacjentow v2`.`pacjenci`.`Nazwisko` AS `Nazwisko`,`bazapacjentow v2`.`hospitalizacje`.`Data_Przyjecia` AS `Data_Przyjecia`,`bazapacjentow v2`.`hospitalizacje`.`Rozpoznanie_Glowne` AS `Rozpoznanie_Glowne`,`bazapacjentow v2`.`hospitalizacje`.`rehabilitacja` AS `rehabilitacja`,`bazapacjentow v2`.`hospitalizacje`.`kardiologia` AS `kardiologia`,`bazapacjentow v2`.`hospitalizacje`.`ink` AS `ink`,`bazapacjentow v2`.`hospitalizacje`.`Wypis_Plik` AS `Wypis_Plik` from (`bazapacjentow v2`.`hospitalizacje` left join `bazapacjentow v2`.`pacjenci` on((`bazapacjentow v2`.`hospitalizacje`.`PESEL_Pacjenta` = `bazapacjentow v2`.`pacjenci`.`PESEL`))) where (`bazapacjentow v2`.`hospitalizacje`.`powiazano` is not null))) `powiazane_wypisy` left join (select count(`bazapacjentow v2`.`hosp_rozp`.`NumKG`) AS `ilosc_rozpoznan`,`bazapacjentow v2`.`hosp_rozp`.`NumKG` AS `N` from `bazapacjentow v2`.`hosp_rozp` group by `bazapacjentow v2`.`hosp_rozp`.`NumKG`) `sel` on((`powiazane_wypisy`.`NumKg` = `sel`.`N`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `niepowiazane_wypisy`
--

/*!50001 DROP VIEW IF EXISTS `niepowiazane_wypisy`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`Konrad`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `niepowiazane_wypisy` AS select `hospitalizacje`.`NumKg` AS `NumKg`,`pacjenci`.`PESEL` AS `PESEL`,`pacjenci`.`Imie` AS `Imie`,`pacjenci`.`Nazwisko` AS `Nazwisko`,`hospitalizacje`.`Data_Przyjecia` AS `Data_Przyjecia`,`hospitalizacje`.`Rozpoznanie_Glowne` AS `Rozpoznanie_Glowne`,`hospitalizacje`.`rehabilitacja` AS `rehabilitacja`,`hospitalizacje`.`kardiologia` AS `kardiologia`,`hospitalizacje`.`ink` AS `ink` from (`hospitalizacje` left join `pacjenci` on((`hospitalizacje`.`PESEL_Pacjenta` = `pacjenci`.`PESEL`))) where isnull(`hospitalizacje`.`powiazano`) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-09-26  2:00:07
