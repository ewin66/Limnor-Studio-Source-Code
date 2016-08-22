﻿/*
 
 * Author:	Bob Limnor (info@limnor.com)
 * Project: Limnor Studio
 * Item:	Visual Object Builder Utility
 * License: GNU General Public License v3.0
 
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace VPL
{
	public delegate void fnCollectLanguageIcons(ImageList imageList);
	public delegate Image fnGetLanguageImageByName(string cultureName);
}