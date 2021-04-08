﻿using System.Collections.Generic;
using System;
using programming_project.controllers;

namespace programming_project
{
    class Program
    {
        static void Main(string[] args)
        {
            /* App initialization */
            initialization();
        }

        static void initialization(){
            /* UserController instance to init */
            UserController user = new UserController();
            user.init();
        }
    }
}
