# Architecture

## Table of Contents

* ### Introduction
    
* ### Architecture and Frameworks

* ### Basic Website Flow
    
## Introduction

This document serves as a way to clarify the software design of the Brewski++ website.  It will go into detail about the MVC architecture model, the frameworks needed to achieve this model, as well as a general use-case for Client-Side operation.

## Architecture and Frameworks

We are using a Model - View - Controller modular design for our website implementation.  For simplicity in this document, we will analyze these three modules separately and how they relate to the front-end and back-end view of our website.

### Model (Database):

The Model is our database operations.  Only the Controller may connect with the database; the View is should never be allowed to communicate with the database.  We will be using MySQL (potentially SQLite) for our database operations.

### View (Front-End):

This is our client-side operations that will be located in our "View" folder.  The View listens to the Controller and makes no decisions for itself.  We will be using JavaScript and HTML for these operations.

### Controller (Back-End):

The Controller is the middle-man between the View and Model.  The bulk of logical operations will be located in the "Controller" folder.  We will be using ASP.NET Core for these operations.

## Basic Website Flow 

The Client enters information about a specific beer they have tried and adds it to a list.  The View sends these entries to the Controller.  The Controller communicates with the Model and information is stored here.  The Model confirms and directs back to the Controller which then leads back to the View.  The View sends confirmation to the User about their entry.  
