/*
Navicat MySQL Data Transfer

Source Server         : MySQL
Source Server Version : 50617
Source Host           : localhost:3306
Source Database       : jadwal_kuliah

Target Server Type    : MYSQL
Target Server Version : 50617
File Encoding         : 65001

Date: 2016-05-14 20:24:43
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for dosen
-- ----------------------------
DROP TABLE IF EXISTS `dosen`;
CREATE TABLE `dosen` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nama` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of dosen
-- ----------------------------

-- ----------------------------
-- Table structure for larangan
-- ----------------------------
DROP TABLE IF EXISTS `larangan`;
CREATE TABLE `larangan` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_dosen` int(11) DEFAULT NULL,
  `id_waktu` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_dosen` (`id_dosen`),
  KEY `id_waktu` (`id_waktu`),
  CONSTRAINT `larangan_ibfk_1` FOREIGN KEY (`id_dosen`) REFERENCES `dosen` (`id`),
  CONSTRAINT `larangan_ibfk_2` FOREIGN KEY (`id_waktu`) REFERENCES `waktu` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of larangan
-- ----------------------------

-- ----------------------------
-- Table structure for matkul
-- ----------------------------
DROP TABLE IF EXISTS `matkul`;
CREATE TABLE `matkul` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nama` varchar(255) DEFAULT NULL,
  `sks` varchar(255) DEFAULT NULL,
  `semester` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of matkul
-- ----------------------------

-- ----------------------------
-- Table structure for matkul_dosen
-- ----------------------------
DROP TABLE IF EXISTS `matkul_dosen`;
CREATE TABLE `matkul_dosen` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_matkul` int(11) DEFAULT NULL,
  `id_dosen` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_matkul` (`id_matkul`),
  KEY `id_dosen` (`id_dosen`),
  CONSTRAINT `matkul_dosen_ibfk_1` FOREIGN KEY (`id_matkul`) REFERENCES `matkul` (`id`),
  CONSTRAINT `matkul_dosen_ibfk_2` FOREIGN KEY (`id_dosen`) REFERENCES `dosen` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of matkul_dosen
-- ----------------------------

-- ----------------------------
-- Table structure for ruangan
-- ----------------------------
DROP TABLE IF EXISTS `ruangan`;
CREATE TABLE `ruangan` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nama` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of ruangan
-- ----------------------------

-- ----------------------------
-- Table structure for user
-- ----------------------------
DROP TABLE IF EXISTS `user`;
CREATE TABLE `user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of user
-- ----------------------------
INSERT INTO `user` VALUES ('1', 'admin', 'admin');

-- ----------------------------
-- Table structure for waktu
-- ----------------------------
DROP TABLE IF EXISTS `waktu`;
CREATE TABLE `waktu` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `hari` int(11) DEFAULT NULL,
  `jam` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of waktu
-- ----------------------------
