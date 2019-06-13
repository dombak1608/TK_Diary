# -*- coding: utf-8 -*-
import clr
clr.AddReference('System.Windows.Forms')
from System.Windows.Forms import *

name1 = 'howToUse'
name2 = 'contact'
name3 = 'aboutApp'

def howToUse(sender, args):
    mssg = 'Za prikaz svih upisanih igrača odaberite: "Igrači"\n'
    mssg += 'Za prikaz svih upisanih turnira odaberite: "Turniri"\n'
    mssg += 'Za prikaz statistike turnira odaberite: "Statistika"\n'
    mssg += 'Za prikaz tablice bodova igrača odaberite: "Bodovi"\n'
    mssg += 'Za dodavanje turnira odaberite "Dodaj novi" unutar prozora "Turniri"\n'
    mssg += '\nUpozorenje, svi igrači kojima se upisuju bodovi u turniru moraju prethodno biti upisani, u protivnom, bodovi im se neće upisati\n'
    MessageBox.Show(mssg, "Kako se koristi")

def contact(sender, args):
    mssg = 'Aplikaciju izradio: Domagoj Karl\n'
    mssg += 'E-mail: karl.domagoj@gmail.com\n'
    MessageBox.Show(mssg, "Kontakt")

def aboutApp(sender, args):
    mssg = 'Ova aplikacija je napravljena u svrhu lakšeg vođenja teniskih turnira.\n'
    mssg += 'Kroz aplikaciju se može viditi evidencija o igračima te svim odigranim mečevima unutar unesenih turnira.\n\n'
    mssg += 'Za upute korištenja kliknite na Pomoć -> Kako se koristi\n'
    mssg += 'Za kontakt autora kliknite na Pomoć -> Kontakt'
    MessageBox.Show(mssg, "O aplikaciji")

def LoadExtension(frm):
    newItem = ToolStripMenuItem(Name=name1, Text='Kako se koristi')
    newItem.Click += howToUse
    newItem.Tag = frm
    frm.pomocToolStripMenuItem.DropDownItems.Add(newItem)

    newItem = ToolStripMenuItem(Name=name2, Text='Kontakt')
    newItem.Click += contact
    newItem.Tag = frm
    frm.pomocToolStripMenuItem.DropDownItems.Add(newItem)

    newItem = ToolStripMenuItem(Name=name3, Text='O aplikaciji')
    newItem.Click += aboutApp
    newItem.Tag = frm
    frm.pomocToolStripMenuItem.DropDownItems.Add(newItem)
