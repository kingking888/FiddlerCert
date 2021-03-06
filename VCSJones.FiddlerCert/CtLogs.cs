﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Cryptography;

namespace VCSJones.FiddlerCert
{
    public static class CtLogs
    {
        public static ReadOnlyCollection<CtLogInfo> Logs { get; } = new List<CtLogInfo> {
            new CtLogInfo
            {
                Name = "Google 'Aviator' Log",
                Url = "https://ct.googleapis.com/aviator/",
                Key = new byte [] { 0x30, 0x59, 0x30, 0x13, 0x06, 0x07, 0x2a, 0x86, 0x48, 0xce, 0x3d, 0x02, 0x01, 0x06, 0x08, 0x2a, 0x86
                                  , 0x48, 0xce, 0x3d, 0x03, 0x01, 0x07, 0x03, 0x42, 0x00, 0x04, 0xd7, 0xf4, 0xcc, 0x69, 0xb2, 0xe4, 0x0e
                                  , 0x90, 0xa3, 0x8a, 0xea, 0x5a, 0x70, 0x09, 0x4f, 0xef, 0x13, 0x62, 0xd0, 0x8d, 0x49, 0x60, 0xff, 0x1b
                                  , 0x40, 0x50, 0x07, 0x0c, 0x6d, 0x71, 0x86, 0xda, 0x25, 0x49, 0x8d, 0x65, 0xe1, 0x08, 0x0d, 0x47, 0x34
                                  , 0x6b, 0xbd, 0x27, 0xbc, 0x96, 0x21, 0x3e, 0x34, 0xf5, 0x87, 0x76, 0x31, 0xb1, 0x7f, 0x1d, 0xc9, 0x85
                                  , 0x3b, 0x0d, 0xf7, 0x1f, 0x3f, 0xe9 }
            },
            new CtLogInfo
            {
                Name = "Google 'Icarus' Log",
                Url = "https://ct.googleapis.com/icarus/",
                Key = new byte [] { 0x30, 0x59, 0x30, 0x13, 0x06, 0x07, 0x2a, 0x86, 0x48, 0xce, 0x3d, 0x02, 0x01, 0x06, 0x08, 0x2a, 0x86
                                  , 0x48, 0xce, 0x3d, 0x03, 0x01, 0x07, 0x03, 0x42, 0x00, 0x04, 0x4e, 0xd2, 0xbc, 0xbf, 0xb3, 0x08, 0x0a
                                  , 0xf7, 0xb9, 0xea, 0xa4, 0xc7, 0x1c, 0x38, 0x61, 0x04, 0xeb, 0x95, 0xe0, 0x89, 0x54, 0x68, 0x44, 0xb1
                                  , 0x66, 0xbc, 0x82, 0x7e, 0x4f, 0x50, 0x6c, 0x6f, 0x5c, 0xa3, 0xf0, 0xaa, 0x3e, 0xf4, 0xec, 0x80, 0xf0
                                  , 0xdb, 0x0a, 0x9a, 0x7a, 0xa0, 0x5b, 0x72, 0x00, 0x7c, 0x25, 0x0e, 0x19, 0xef, 0xaf, 0xb2, 0x62, 0x8d
                                  , 0x74, 0x43, 0xf4, 0x26, 0xf6, 0x14 }
            },
            new CtLogInfo
            {
                Name = "Google 'Pilot' Log",
                Url = "https://ct.googleapis.com/pilot/",
                Key = new byte[] { 0x30, 0x59, 0x30, 0x13, 0x06, 0x07, 0x2a, 0x86, 0x48, 0xce, 0x3d, 0x02, 0x01, 0x06, 0x08, 0x2a, 0x86
                                 , 0x48, 0xce, 0x3d, 0x03, 0x01, 0x07, 0x03, 0x42, 0x00, 0x04, 0x7d, 0xa8, 0x4b, 0x12, 0x29, 0x80, 0xa3
                                 , 0x3d, 0xad, 0xd3, 0x5a, 0x77, 0xb8, 0xcc, 0xe2, 0x88, 0xb3, 0xa5, 0xfd, 0xf1, 0xd3, 0x0c, 0xcd, 0x18
                                 , 0x0c, 0xe8, 0x41, 0x46, 0xe8, 0x81, 0x01, 0x1b, 0x15, 0xe1, 0x4b, 0xf1, 0x1b, 0x62, 0xdd, 0x36, 0x0a
                                 , 0x08, 0x18, 0xba, 0xed, 0x0b, 0x35, 0x84, 0xd0, 0x9e, 0x40, 0x3c, 0x2d, 0x9e, 0x9b, 0x82, 0x65, 0xbd
                                 , 0x1f, 0x04, 0x10, 0x41, 0x4c, 0xa0 }
            },
            new CtLogInfo
            {
                Name = "Google 'Rocketeer' log",
                Url = "https://ct.googleapis.com/rocketeer/",
                Key = new byte[] { 0x30, 0x59, 0x30, 0x13, 0x06, 0x07, 0x2a, 0x86, 0x48, 0xce, 0x3d, 0x02, 0x01, 0x06, 0x08, 0x2a, 0x86
                                 , 0x48, 0xce, 0x3d, 0x03, 0x01, 0x07, 0x03, 0x42, 0x00, 0x04, 0x20, 0x5b, 0x18, 0xc8, 0x3c, 0xc1, 0x8b
                                 , 0xb3, 0x31, 0x08, 0x00, 0xbf, 0xa0, 0x90, 0x57, 0x2b, 0xb7, 0x47, 0x8c, 0x6f, 0xb5, 0x68, 0xb0, 0x8e
                                 , 0x90, 0x78, 0xe9, 0xa0, 0x73, 0xea, 0x4f, 0x28, 0x21, 0x2e, 0x9c, 0xc0, 0xf4, 0x16, 0x1b, 0xaa, 0xf9
                                 , 0xd5, 0xd7, 0xa9, 0x80, 0xc3, 0x4e, 0x2f, 0x52, 0x3c, 0x98, 0x01, 0x25, 0x46, 0x24, 0x25, 0x28, 0x23
                                 , 0x77, 0x2d, 0x05, 0xc2, 0x40, 0x7a }
            },
            new CtLogInfo
            {
                Name = "Google 'Skydiver' log",
                Url = "https://ct.googleapis.com/skydiver/",
                Key = new byte[] { 0x30, 0x59, 0x30, 0x13, 0x06, 0x07, 0x2a, 0x86, 0x48, 0xce, 0x3d, 0x02, 0x01, 0x06, 0x08, 0x2a, 0x86
                                 , 0x48, 0xce, 0x3d, 0x03, 0x01, 0x07, 0x03, 0x42, 0x00, 0x04, 0x12, 0x6c, 0x86, 0x0e, 0xf6, 0x17, 0xb1
                                 , 0x12, 0x6c, 0x37, 0x25, 0xd2, 0xad, 0x87, 0x3d, 0x0e, 0x31, 0xec, 0x21, 0xad, 0xb1, 0xcd, 0xbe, 0x14
                                 , 0x47, 0xb6, 0x71, 0x56, 0x85, 0x7a, 0x9a, 0xb7, 0x3d, 0x89, 0x90, 0x7b, 0xc6, 0x32, 0x3a, 0xf8, 0xda
                                 , 0xce, 0x8b, 0x01, 0xfe, 0x3f, 0xfc, 0x71, 0x91, 0x19, 0x8e, 0x14, 0x6e, 0x89, 0x7a, 0x5d, 0xb4, 0xab
                                 , 0x7e, 0xe1, 0x4e, 0x1e, 0x7c, 0xac }
            },
            new CtLogInfo
            {
                Name = "DigiCert Log Server",
                Url = "https://ct1.digicert-ct.com/log/",
                Key = new byte[] { 0x30, 0x59, 0x30, 0x13, 0x06, 0x07, 0x2a, 0x86, 0x48, 0xce, 0x3d, 0x02, 0x01, 0x06, 0x08, 0x2a, 0x86
                                 , 0x48, 0xce, 0x3d, 0x03, 0x01, 0x07, 0x03, 0x42, 0x00, 0x04, 0x02, 0x46, 0xc5, 0xbe, 0x1b, 0xbb, 0x82
                                 , 0x40, 0x16, 0xe8, 0xc1, 0xd2, 0xac, 0x19, 0x69, 0x13, 0x59, 0xf8, 0xf8, 0x70, 0x85, 0x46, 0x40, 0xb9
                                 , 0x38, 0xb0, 0x23, 0x82, 0xa8, 0x64, 0x4c, 0x7f, 0xbf, 0xbb, 0x34, 0x9f, 0x4a, 0x5f, 0x28, 0x8a, 0xcf
                                 , 0x19, 0xc4, 0x00, 0xf6, 0x36, 0x06, 0x93, 0x65, 0xed, 0x4c, 0xf5, 0xa9, 0x21, 0x62, 0x5a, 0xd8, 0x91
                                 , 0xeb, 0x38, 0x24, 0x40, 0xac, 0xe8 }
            },
            new CtLogInfo
            {
                Name = "DigiCert Log Server 2",
                Url = "https://ct2.digicert-ct.com/log/",
                Key = new byte[] {   0x30, 0x59, 0x30, 0x13, 0x06, 0x07, 0x2a, 0x86, 0x48, 0xce, 0x3d, 0x02, 0x01, 0x06, 0x08, 0x2a, 0x86
                                   , 0x48, 0xce, 0x3d, 0x03, 0x01, 0x07, 0x03, 0x42, 0x00, 0x04, 0xcc, 0x5d, 0x39, 0x2f, 0x66, 0xb8, 0x4c
                                   , 0x7f, 0xc1, 0x2e, 0x03, 0xa1, 0x34, 0xa3, 0xe8, 0x8a, 0x86, 0x02, 0xae, 0x4a, 0x11, 0xc6, 0xf7, 0x26
                                   , 0x6a, 0x37, 0x9b, 0xf0, 0x38, 0xf8, 0x5d, 0x09, 0x8d, 0x63, 0xe8, 0x31, 0x6b, 0x86, 0x66, 0xcf, 0x79
                                   , 0xb3, 0x25, 0x3c, 0x1e, 0xdf, 0x78, 0xb4, 0xa8, 0xc5, 0x69, 0xfa, 0xb7, 0xf0, 0x82, 0x79, 0x62, 0x43
                                   , 0xf6, 0xcc, 0xfe, 0x81, 0x66, 0x84 }
            },
            new CtLogInfo
            {
                Name = "Symantec log",
                Url = "https://ct.ws.symantec.com/",
                Key = new byte[] { 0x30, 0x59, 0x30, 0x13, 0x06, 0x07, 0x2a, 0x86, 0x48, 0xce, 0x3d, 0x02, 0x01, 0x06, 0x08, 0x2a, 0x86
                                 , 0x48, 0xce, 0x3d, 0x03, 0x01, 0x07, 0x03, 0x42, 0x00, 0x04, 0x96, 0xea, 0xac, 0x1c, 0x46, 0x0c, 0x1b
                                 , 0x55, 0xdc, 0x0d, 0xfc, 0xb5, 0x94, 0x27, 0x46, 0x57, 0x42, 0x70, 0x3a, 0x69, 0x18, 0xe2, 0xbf, 0x3b
                                 , 0xc4, 0xdb, 0xab, 0xa0, 0xf4, 0xb6, 0x6c, 0xc0, 0x53, 0x3f, 0x4d, 0x42, 0x10, 0x33, 0xf0, 0x58, 0x97
                                 , 0x8f, 0x6b, 0xbe, 0x72, 0xf4, 0x2a, 0xec, 0x1c, 0x42, 0xaa, 0x03, 0x2f, 0x1a, 0x7e, 0x28, 0x35, 0x76
                                 , 0x99, 0x08, 0x3d, 0x21, 0x14, 0x86 }
            },
            new CtLogInfo
            {
                Name = "Symantec 'Vega' log",
                Url = "https://vega.ws.symantec.com/",
                Key = new byte[] { 0x30, 0x59, 0x30, 0x13, 0x06, 0x07, 0x2a, 0x86, 0x48, 0xce, 0x3d, 0x02, 0x01, 0x06, 0x08, 0x2a, 0x86
                                 , 0x48, 0xce, 0x3d, 0x03, 0x01, 0x07, 0x03, 0x42, 0x00, 0x04, 0xea, 0x95, 0x9e, 0x02, 0xff, 0xee, 0xf1
                                 , 0x33, 0x6d, 0x4b, 0x87, 0xbc, 0xcd, 0xfd, 0x19, 0x17, 0x62, 0xff, 0x94, 0xd3, 0xd0, 0x59, 0x07, 0x3f
                                 , 0x02, 0x2d, 0x1c, 0x90, 0xfe, 0xc8, 0x47, 0x30, 0x3b, 0xf1, 0xdd, 0x0d, 0xb8, 0x11, 0x0c, 0x5d, 0x1d
                                 , 0x86, 0xdd, 0xab, 0xd3, 0x2b, 0x46, 0x66, 0xfb, 0x6e, 0x65, 0xb7, 0x3b, 0xfd, 0x59, 0x68, 0xac, 0xdf
                                 , 0xa6, 0xf8, 0xce, 0xd2, 0x18, 0x4d }
            },
            new CtLogInfo
            {
                Name = "Symantec 'Sirius' log",
                Url = "https://sirius.ws.symantec.com/",
                Key = new byte[] { 0x30, 0x59, 0x30, 0x13, 0x06, 0x07, 0x2a, 0x86, 0x48, 0xce, 0x3d, 0x02, 0x01, 0x06, 0x08, 0x2a, 0x86
                                 , 0x48, 0xce, 0x3d, 0x03, 0x01, 0x07, 0x03, 0x42, 0x00, 0x04, 0xa3, 0x02, 0x64, 0x84, 0x22, 0xbb, 0x25
                                 , 0xec, 0x0d, 0xe3, 0xbc, 0xc2, 0xc9, 0x89, 0x7d, 0xdd, 0x45, 0xd0, 0xee, 0xe6, 0x15, 0x85, 0x8f, 0xd9
                                 , 0xe7, 0x17, 0x1b, 0x13, 0x80, 0xea, 0xed, 0xb2, 0x85, 0x37, 0xad, 0x6a, 0xc5, 0xd8, 0x25, 0x9d, 0xfa
                                 , 0xf4, 0xb4, 0xf3, 0x6e, 0x16, 0x28, 0x25, 0x37, 0xea, 0xa3, 0x37, 0x64, 0xb2, 0xc7, 0x0b, 0xfd, 0x51
                                 , 0xe5, 0xc1, 0x05, 0xf4, 0x0e, 0xb5 }
            },
            new CtLogInfo
            {
                Name = "WoSign log",
                Url = "https://ctlog.wosign.com/",
                Key = new byte[] { 0x30, 0x59, 0x30, 0x13, 0x06, 0x07, 0x2a, 0x86, 0x48, 0xce, 0x3d, 0x02, 0x01, 0x06, 0x08, 0x2a, 0x86
                                 , 0x48, 0xce, 0x3d, 0x03, 0x01, 0x07, 0x03, 0x42, 0x00, 0x04, 0xcc, 0x11, 0x88, 0x7b, 0x2d, 0x66, 0xcb
                                 , 0xae, 0x8f, 0x4d, 0x30, 0x66, 0x27, 0x19, 0x25, 0x22, 0x93, 0x21, 0x46, 0xb4, 0x2f, 0x01, 0xd3, 0xc6
                                 , 0xf9, 0x2b, 0xd5, 0xc8, 0xba, 0x73, 0x9b, 0x06, 0xa2, 0xf0, 0x8a, 0x02, 0x9c, 0xd0, 0x6b, 0x46, 0x18
                                 , 0x30, 0x85, 0xba, 0xe9, 0x24, 0x8b, 0x0e, 0xd1, 0x5b, 0x70, 0x28, 0x0c, 0x7e, 0xf1, 0x3a, 0x45, 0x7f
                                 , 0x5a, 0xf3, 0x82, 0x42, 0x60, 0x31 }
            },
            new CtLogInfo
            {
                Name = "Venafi Gen2 CT log",
                Url = "https://ctlog-gen2.api.venafi.com/",
                Key =  new byte[] { 0x30, 0x59, 0x30, 0x13, 0x06, 0x07, 0x2a, 0x86, 0x48, 0xce, 0x3d, 0x02, 0x01, 0x06, 0x08, 0x2a, 0x86
                                  , 0x48, 0xce, 0x3d, 0x03, 0x01, 0x07, 0x03, 0x42, 0x00, 0x04, 0x8e, 0x27, 0x27, 0x7a, 0xb6, 0x55, 0x09
                                  , 0x74, 0xeb, 0x6c, 0x4b, 0x94, 0x84, 0x65, 0xbc, 0xe4, 0x15, 0xf1, 0xea, 0x5a, 0xd8, 0x7c, 0x0e, 0x37
                                  , 0xce, 0xba, 0x3f, 0x6c, 0x09, 0xda, 0xe7, 0x29, 0x96, 0xd3, 0x45, 0x50, 0x6f, 0xde, 0x1e, 0xb4, 0x1c
                                  , 0xd2, 0x83, 0x88, 0xff, 0x29, 0x2f, 0xce, 0xa9, 0xff, 0xdf, 0x34, 0xde, 0x75, 0x0f, 0xc0, 0xcc, 0x18
                                  , 0x0d, 0x94, 0x2e, 0xfc, 0x37, 0x01 }
            },
            new CtLogInfo
            {
                Name = "CNNIC CT log",
                Url = "https://ctserver.cnnic.cn/",
                Key = new byte[] { 0x30, 0x82, 0x01, 0x22, 0x30, 0x0d, 0x06, 0x09, 0x2a, 0x86, 0x48, 0x86, 0xf7, 0x0d, 0x01, 0x01, 0x01
                                 , 0x05, 0x00, 0x03, 0x82, 0x01, 0x0f, 0x00, 0x30, 0x82, 0x01, 0x0a, 0x02, 0x82, 0x01, 0x01, 0x00, 0xbf
                                 , 0xb5, 0x08, 0x61, 0x9a, 0x29, 0x32, 0x04, 0xd3, 0x25, 0x63, 0xe9, 0xd8, 0x85, 0xe1, 0x86, 0xe0, 0x1f
                                 , 0xd6, 0x5e, 0x9a, 0xf7, 0x33, 0x3b, 0x80, 0x1b, 0xe7, 0xb6, 0x3e, 0x5f, 0x2d, 0xa1, 0x66, 0xf6, 0x95
                                 , 0x4a, 0x84, 0xa6, 0x21, 0x56, 0x79, 0xe8, 0xf7, 0x85, 0xee, 0x5d, 0xe3, 0x7c, 0x12, 0xc0, 0xe0, 0x89
                                 , 0x22, 0x09, 0x22, 0x3e, 0xba, 0x16, 0x95, 0x06, 0xbd, 0xa8, 0xb9, 0xb1, 0xa9, 0xb2, 0x7a, 0xd6, 0x61
                                 , 0x2e, 0x87, 0x11, 0xb9, 0x78, 0x40, 0x89, 0x75, 0xdb, 0x0c, 0xdc, 0x90, 0xe0, 0xa4, 0x79, 0xd6, 0xd5
                                 , 0x5e, 0x6e, 0xd1, 0x2a, 0xdb, 0x34, 0xf4, 0x99, 0x3f, 0x65, 0x89, 0x3b, 0x46, 0xc2, 0x29, 0x2c, 0x15
                                 , 0x07, 0x1c, 0xc9, 0x4b, 0x1a, 0x54, 0xf8, 0x6c, 0x1e, 0xaf, 0x60, 0x27, 0x62, 0x0a, 0x65, 0xd5, 0x9a
                                 , 0xb9, 0x50, 0x36, 0x16, 0x6e, 0x71, 0xf6, 0x1f, 0x01, 0xf7, 0x12, 0xa7, 0xfc, 0xbf, 0xf6, 0x21, 0xa3
                                 , 0x29, 0x90, 0x86, 0x2d, 0x77, 0xde, 0xbb, 0x4c, 0xd4, 0xcf, 0xfd, 0xd2, 0xcf, 0x82, 0x2c, 0x4d, 0xd4
                                 , 0xf2, 0xc2, 0x2d, 0xac, 0xa9, 0xbe, 0xea, 0xc3, 0x19, 0x25, 0x43, 0xb2, 0xe5, 0x9a, 0x6c, 0x0d, 0xc5
                                 , 0x1c, 0xa5, 0x8b, 0xf7, 0x3f, 0x30, 0xaf, 0xb9, 0x01, 0x91, 0xb7, 0x69, 0x12, 0x12, 0xe5, 0x83, 0x61
                                 , 0xfe, 0x34, 0x00, 0xbe, 0xf6, 0x71, 0x8a, 0xc7, 0xeb, 0x50, 0x92, 0xe8, 0x59, 0xfe, 0x15, 0x91, 0xeb
                                 , 0x96, 0x97, 0xf8, 0x23, 0x54, 0x3f, 0x2d, 0x8e, 0x07, 0xdf, 0xee, 0xda, 0xb3, 0x4f, 0xc8, 0x3c, 0x9d
                                 , 0x6f, 0xdf, 0x3c, 0x2c, 0x43, 0x57, 0xa1, 0x47, 0x0c, 0x91, 0x04, 0xf4, 0x75, 0x4d, 0xda, 0x89, 0x81
                                 , 0xa4, 0x14, 0x06, 0x34, 0xb9, 0x98, 0xc3, 0xda, 0xf1, 0xfd, 0xed, 0x33, 0x36, 0xd3, 0x16, 0x2d, 0x35
                                 , 0x02, 0x03, 0x01, 0x00, 0x01 }
            },
            new CtLogInfo
            {
                Name = "StartCom CT log",
                Url = "https://ct.startssl.com/",
                Key = new byte[] { 0x30, 0x59, 0x30, 0x13, 0x06, 0x07, 0x2a, 0x86, 0x48, 0xce, 0x3d, 0x02, 0x01, 0x06, 0x08, 0x2a, 0x86
                                 , 0x48, 0xce, 0x3d, 0x03, 0x01, 0x07, 0x03, 0x42, 0x00, 0x04, 0x48, 0xf3, 0x59, 0xf3, 0xf6, 0x05, 0x18
                                 , 0xd3, 0xdb, 0xb2, 0xed, 0x46, 0x7e, 0xcf, 0xc8, 0x11, 0xb5, 0x57, 0xb1, 0xa8, 0xd6, 0x4c, 0xe6, 0x9f
                                 , 0xb7, 0x4a, 0x1a, 0x14, 0x86, 0x43, 0xa9, 0x48, 0xb0, 0xcb, 0x5a, 0x3f, 0x3c, 0x4a, 0xca, 0xdf, 0xc4
                                 , 0x82, 0x14, 0x55, 0x9a, 0xf8, 0xf7, 0x8e, 0x40, 0x55, 0xdc, 0xf4, 0xd2, 0xaf, 0xea, 0x75, 0x74, 0xfb
                                 , 0x4e, 0x7f, 0x60, 0x86, 0x2e, 0x51 }
            },
            new CtLogInfo
            {
                Name = "Comodo 'Sabre' CT log",
                Url = "https://sabre.ct.comodo.com/",
                Key = new byte[] { 0x30, 0x59, 0x30, 0x13, 0x06, 0x07, 0x2a, 0x86, 0x48, 0xce, 0x3d, 0x02, 0x01, 0x06, 0x08, 0x2a, 0x86
                                 , 0x48, 0xce, 0x3d, 0x03, 0x01, 0x07, 0x03, 0x42, 0x00, 0x04, 0xf2, 0x6f, 0xd2, 0x89, 0x0f, 0x3f, 0xc5
                                 , 0xf8, 0x87, 0x1e, 0xab, 0x65, 0xb3, 0xd9, 0xbb, 0x17, 0x23, 0x8c, 0x06, 0x0e, 0x09, 0x55, 0x96, 0x3d
                                 , 0x0a, 0x08, 0xa2, 0xc5, 0x71, 0xb3, 0xd1, 0xa9, 0x2f, 0x28, 0x3e, 0x83, 0x10, 0xbf, 0x12, 0xd0, 0x44
                                 , 0x66, 0x15, 0xef, 0x54, 0xe1, 0x98, 0x80, 0xd0, 0xce, 0x24, 0x6d, 0x3e, 0x67, 0x9a, 0xe9, 0x37, 0x23
                                 , 0xce, 0x52, 0x93, 0x86, 0xda, 0x80 }
            },
            new CtLogInfo
            {
                Name = "Comodo 'Mammoth' CT log",
                Url = "https://mammoth.ct.comodo.com/",
                Key = new byte[] { 0x30, 0x59, 0x30, 0x13, 0x06, 0x07, 0x2a, 0x86, 0x48, 0xce, 0x3d, 0x02, 0x01, 0x06, 0x08, 0x2a, 0x86
                                 , 0x48, 0xce, 0x3d, 0x03, 0x01, 0x07, 0x03, 0x42, 0x00, 0x04, 0xef, 0xe4, 0x7d, 0x74, 0x2e, 0x15, 0x15
                                 , 0xb6, 0xe9, 0xbb, 0x23, 0x8b, 0xfb, 0x2c, 0xb5, 0xe1, 0xc7, 0x80, 0x98, 0x47, 0xfb, 0x40, 0x69, 0x68
                                 , 0xfc, 0x49, 0xad, 0x61, 0x4e, 0x83, 0x47, 0x3c, 0x1a, 0xb7, 0x8d, 0xdf, 0xff, 0x7b, 0x30, 0xb4, 0xba
                                 , 0xff, 0x2f, 0xcb, 0xa0, 0x14, 0xe3, 0xad, 0xd5, 0x85, 0x3f, 0x44, 0x59, 0x8c, 0x8c, 0x60, 0x8b, 0xd7
                                 , 0xb8, 0xb1, 0xbf, 0xae, 0x8c, 0x67 }

            },
            //Begin disqualified logs
            new CtLogInfo
            {
                Name = "Izenpe log",
                Url = "https://ct.izenpe.com/",
                Key = new byte[] { 0x30, 0x59, 0x30, 0x13, 0x06, 0x07, 0x2a, 0x86, 0x48, 0xce, 0x3d, 0x02, 0x01, 0x06, 0x08, 0x2a, 0x86
                                 , 0x48, 0xce, 0x3d, 0x03, 0x01, 0x07, 0x03, 0x42, 0x00, 0x04, 0x27, 0x64, 0x39, 0x0c, 0x2d, 0xdc, 0x50
                                 , 0x18, 0xf8, 0x21, 0x00, 0xa2, 0x0e, 0xed, 0x2c, 0xea, 0x3e, 0x75, 0xba, 0x9f, 0x93, 0x64, 0x09, 0x00
                                 , 0x11, 0xc4, 0x11, 0x17, 0xab, 0x5c, 0xcf, 0x0f, 0x74, 0xac, 0xb5, 0x97, 0x90, 0x93, 0x00, 0x5b, 0xb8
                                 , 0xeb, 0xf7, 0x27, 0x3d, 0xd9, 0xb2, 0x0a, 0x81, 0x5f, 0x2f, 0x0d, 0x75, 0x38, 0x94, 0x37, 0x99, 0x1e
                                 , 0xf6, 0x07, 0x76, 0xe0, 0xee, 0xbe }
            },
            new CtLogInfo
             {
                Name = "Certly.IO Log",
                Url = "https://log.certly.io/",
                Key = new byte[] { 0x30, 0x59, 0x30, 0x13, 0x06, 0x07, 0x2a, 0x86, 0x48, 0xce, 0x3d, 0x02, 0x01, 0x06, 0x08, 0x2a, 0x86
                                 , 0x48, 0xce, 0x3d, 0x03, 0x01, 0x07, 0x03, 0x42, 0x00, 0x04, 0x0b, 0x23, 0xcb, 0x85, 0x62, 0x98, 0x61
                                 , 0x48, 0x04, 0x73, 0xeb, 0x54, 0x5d, 0xf3, 0xd0, 0x07, 0x8c, 0x2d, 0x19, 0x2d, 0x8c, 0x36, 0xf5, 0xeb
                                 , 0x8f, 0x01, 0x42, 0x0a, 0x7c, 0x98, 0x26, 0x27, 0xc1, 0xb5, 0xdd, 0x92, 0x93, 0xb0, 0xae, 0xf8, 0x9b
                                 , 0x3d, 0x0c, 0xd8, 0x4c, 0x4e, 0x1d, 0xf9, 0x15, 0xfb, 0x47, 0x68, 0x7b, 0xba, 0x66, 0xb7, 0x25, 0x9c
                                 , 0xd0, 0x4a, 0xc2, 0x66, 0xdb, 0x48 }
            },
            new CtLogInfo
            {
                Name = "Venafi log",
                Url = "https://ctlog.api.venafi.com/",
                Key = new byte[] { 0x30, 0x82, 0x01, 0x22, 0x30, 0x0d, 0x06, 0x09, 0x2a, 0x86, 0x48, 0x86, 0xf7, 0x0d, 0x01, 0x01, 0x01
                                 , 0x05, 0x00, 0x03, 0x82, 0x01, 0x0f, 0x00, 0x30, 0x82, 0x01, 0x0a, 0x02, 0x82, 0x01, 0x01, 0x00, 0xa2
                                 , 0x5a, 0x48, 0x1f, 0x17, 0x52, 0x95, 0x35, 0xcb, 0xa3, 0x5b, 0x3a, 0x1f, 0x53, 0x82, 0x76, 0x94, 0xa3
                                 , 0xff, 0x80, 0xf2, 0x1c, 0x37, 0x3c, 0xc0, 0xb1, 0xbd, 0xc1, 0x59, 0x8b, 0xab, 0x2d, 0x65, 0x93, 0xd7
                                 , 0xf3, 0xe0, 0x04, 0xd5, 0x9a, 0x6f, 0xbf, 0xd6, 0x23, 0x76, 0x36, 0x4f, 0x23, 0x99, 0xcb, 0x54, 0x28
                                 , 0xad, 0x8c, 0x15, 0x4b, 0x65, 0x59, 0x76, 0x41, 0x4a, 0x9c, 0xa6, 0xf7, 0xb3, 0x3b, 0x7e, 0xb1, 0xa5
                                 , 0x49, 0xa4, 0x17, 0x51, 0x6c, 0x80, 0xdc, 0x2a, 0x90, 0x50, 0x4b, 0x88, 0x24, 0xe9, 0xa5, 0x12, 0x32
                                 , 0x93, 0x04, 0x48, 0x90, 0x02, 0xfa, 0x5f, 0x0e, 0x30, 0x87, 0x8e, 0x55, 0x76, 0x05, 0xee, 0x2a, 0x4c
                                 , 0xce, 0xa3, 0x6a, 0x69, 0x09, 0x6e, 0x25, 0xad, 0x82, 0x76, 0x0f, 0x84, 0x92, 0xfa, 0x38, 0xd6, 0x86
                                 , 0x4e, 0x24, 0x8f, 0x9b, 0xb0, 0x72, 0xcb, 0x9e, 0xe2, 0x6b, 0x3f, 0xe1, 0x6d, 0xc9, 0x25, 0x75, 0x23
                                 , 0x88, 0xa1, 0x18, 0x58, 0x06, 0x23, 0x33, 0x78, 0xda, 0x00, 0xd0, 0x38, 0x91, 0x67, 0xd2, 0xa6, 0x7d
                                 , 0x27, 0x97, 0x67, 0x5a, 0xc1, 0xf3, 0x2f, 0x17, 0xe6, 0xea, 0xd2, 0x5b, 0xe8, 0x81, 0xcd, 0xfd, 0x92
                                 , 0x68, 0xe7, 0xf3, 0x06, 0xf0, 0xe9, 0x72, 0x84, 0xee, 0x01, 0xa5, 0xb1, 0xd8, 0x33, 0xda, 0xce, 0x83
                                 , 0xa5, 0xdb, 0xc7, 0xcf, 0xd6, 0x16, 0x7e, 0x90, 0x75, 0x18, 0xbf, 0x16, 0xdc, 0x32, 0x3b, 0x6d, 0x8d
                                 , 0xab, 0x82, 0x17, 0x1f, 0x89, 0x20, 0x8d, 0x1d, 0x9a, 0xe6, 0x4d, 0x23, 0x08, 0xdf, 0x78, 0x6f, 0xc6
                                 , 0x05, 0xbf, 0x5f, 0xae, 0x94, 0x97, 0xdb, 0x5f, 0x64, 0xd4, 0xee, 0x16, 0x8b, 0xa3, 0x84, 0x6c, 0x71
                                 , 0x2b, 0xf1, 0xab, 0x7f, 0x5d, 0x0d, 0x32, 0xee, 0x04, 0xe2, 0x90, 0xec, 0x41, 0x9f, 0xfb, 0x39, 0xc1
                                 , 0x02, 0x03, 0x01, 0x00, 0x01 }
            },
        }.AsReadOnly();

        public static CtLogInfo FindByLogId(byte[] logId)
        {
            using (var sha = new SHA256Cng())
            {
                foreach(var log in Logs)
                {
                    var hash = sha.ComputeHash(log.Key);
                    if (logId.Length != hash.Length)
                    {
                        continue;
                    }
                    if (hash.MemoryCompare(logId))
                    {
                        return log;
                    }
                }
            }
            return null;
        }

        public static ReadOnlyCollection<RevokedCtLog> RevokedCtLogs { get; } = new List<RevokedCtLog>
        {
            //Izenpe
            new RevokedCtLog
            {
                LogId = new byte[] {0x74, 0x61, 0xb4, 0xa0, 0x9c, 0xfb, 0x3d, 0x41, 0xd7, 0x51, 0x59, 0x57, 0x5b, 0x2e, 0x76, 0x49, 0xa4, 0x45, 0xa8, 0xd2, 0x77, 0x09, 0xb0, 0xcc, 0x56, 0x4a, 0x64, 0x82, 0xb7, 0xeb, 0x41, 0xa3 },
                RevocationEffective = new DateTimeOffset(2016, 5, 30, 0, 0, 0, TimeSpan.Zero)
            },
            //Certly.IO log
            new RevokedCtLog
            {
                LogId = new byte[] {0xcd, 0xb5, 0x17, 0x9b, 0x7f, 0xc1, 0xc0, 0x46, 0xfe, 0xea, 0x31, 0x13, 0x6a, 0x3f, 0x8f, 0x00, 0x2e, 0x61, 0x82, 0xfa, 0xf8, 0x89, 0x6f, 0xec, 0xc8, 0xb2, 0xf5, 0xb5, 0xab, 0x60, 0x49, 0x00 },
                RevocationEffective = new DateTimeOffset(2016, 04, 15, 0, 0, 0, TimeSpan.Zero)
            },
            //Venafi log
            new RevokedCtLog
            {
                LogId = new byte[] { 0xac, 0x3b, 0x9a, 0xed, 0x7f, 0xa9, 0x67, 0x47, 0x57, 0x15, 0x9e, 0x6d, 0x7d, 0x57, 0x56, 0x72, 0xf9, 0xd9, 0x81, 0x00, 0x94, 0x1e, 0x9b, 0xde, 0xff, 0xec, 0xa1, 0x31, 0x3b, 0x75, 0x78, 0x2d },
                RevocationEffective = new DateTimeOffset(2017, 02, 28, 18, 42, 26, TimeSpan.Zero)
            }
        }.AsReadOnly();
    }

    public sealed class RevokedCtLog
    {
        public byte[] LogId { get; set; }
        public DateTimeOffset RevocationEffective { get; set; }
    }


    public sealed class CtLogInfo
    {
        public string Name { get; set; }
        public byte[] Key { get; set; }
        public string Url { get; set; }
    }
}
