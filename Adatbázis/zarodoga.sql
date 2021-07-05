-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2019. Már 28. 12:22
-- Kiszolgáló verziója: 10.1.34-MariaDB
-- PHP verzió: 7.2.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `zarodoga`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `felhasznalo`
--

CREATE TABLE `felhasznalo` (
  `fid` int(50) NOT NULL,
  `felhasznalonev` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `jelszo` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `email` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `osszpontszam` int(11) NOT NULL,
  `tesztszam` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `felhasznalo`
--

INSERT INTO `felhasznalo` (`fid`, `felhasznalonev`, `jelszo`, `email`, `osszpontszam`, `tesztszam`) VALUES
(1, 'ASDVGAILFZ123', '673778122e6976a14dbe6e9663591208', 'judakbarni@gmail.com', 21, 3),
(2, 'Csabagitay500', '9a4016f76f75d7ef5e8212b593fb6083', 'csabikÃ¡maszutra@gmail.com', 11, 1),
(3, 'admin', 'admin', 'admin@gmail.com', 0, 0),
(10, 'Ruben123', 'Ruben123!', 'xd@gmail.com', 39, 10);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `kerdesek`
--

CREATE TABLE `kerdesek` (
  `kerdesszam` int(11) NOT NULL,
  `akerdes` text COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `kerdesek`
--

INSERT INTO `kerdesek` (`kerdesszam`, `akerdes`) VALUES
(1, 'Hány évvel ezelőtt alakult ki a föld ismereteink szerint?'),
(2, 'Mekkora a légnyomás a tengerszinten mért nyomás?'),
(3, 'A naprendszer határa a Naptól hozzvetolegesen mekkora távolság?'),
(4, 'MI ruben vezetÃ©kneve?');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `valaszok`
--

CREATE TABLE `valaszok` (
  `id` int(11) NOT NULL,
  `kerdesszam` int(11) NOT NULL,
  `jovalasz` tinyint(4) NOT NULL DEFAULT '0',
  `valasz` text COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `valaszok`
--

INSERT INTO `valaszok` (`id`, `kerdesszam`, `jovalasz`, `valasz`) VALUES
(1, 1, 1, '3,74 milliárd'),
(2, 1, 0, '4,54 milliárd'),
(3, 1, 0, '2,76 milliárd'),
(4, 1, 0, '5,67 milliárd'),
(5, 2, 0, '103,3 kPa'),
(6, 2, 1, '101,3 kPa'),
(7, 2, 0, '156,45kPa'),
(8, 3, 0, 'kb 3 fényév'),
(9, 3, 0, 'kb 2,4 fényév'),
(10, 3, 0, 'nem tudják nagy pontossággal kiszámolni'),
(11, 3, 1, 'kb. 1 fényév'),
(12, 4, 1, 'BodÃ³'),
(13, 4, 0, 'BobÃ³'),
(14, 4, 0, 'dobÃ³'),
(15, 4, 0, 'tÃ³th');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `felhasznalo`
--
ALTER TABLE `felhasznalo`
  ADD PRIMARY KEY (`fid`);

--
-- A tábla indexei `kerdesek`
--
ALTER TABLE `kerdesek`
  ADD PRIMARY KEY (`kerdesszam`);

--
-- A tábla indexei `valaszok`
--
ALTER TABLE `valaszok`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `felhasznalo`
--
ALTER TABLE `felhasznalo`
  MODIFY `fid` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT a táblához `valaszok`
--
ALTER TABLE `valaszok`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
