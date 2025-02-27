# Advanced Task Management System - Coding Challenge

## Overview
This repository contains a boilerplate for a Task Management System with a C# backend API and React frontend. The system is designed to manage complex tasks with dependencies, priorities, and advanced filtering capabilities.

## Challenge Description
You are tasked with completing a Task Management System that allows users to create, update, delete, and view tasks. The system should handle task dependencies (tasks that must be completed before others can start), priority management, and provide advanced filtering and sorting capabilities.

## Technical Stack
- **Backend**: ASP.NET Core Web API (C#)
- **Frontend**: React with TypeScript
- **State Management**: React Context API and hooks
- **Styling**: CSS Modules or styled-components (your choice)

## Objectives

### Backend Objectives
1. Implement the missing endpoints in the Task Controller
2. Complete the Task Service implementation
3. Add validation for task creation and updates
4. Implement task dependency management logic
5. Add advanced filtering capabilities to the API

### Frontend Objectives
1. Complete the Task component to display task details
2. Implement the form for creating and editing tasks
3. Create a dashboard view with task statistics
4. Implement drag-and-drop functionality for task prioritization
5. Add advanced filtering and sorting UI

## Getting Started

### Quick Setup
For a quick setup, you can use the provided setup script:
```
./setup.sh
```
This will install all dependencies for both the backend and frontend.

### Backend Setup
1. Navigate to the `backend/TodoApi` directory
2. Run `dotnet restore` to restore dependencies
3. Run `dotnet run` to start the API server

### Frontend Setup
1. Navigate to the `frontend/todo-app` directory
2. Run `npm install` to install dependencies
3. Run `npm start` to start the development server

> **Note**: If you encounter any issues with the React app setup, you may need to recreate it using:
> ```
> npx create-react-app frontend/todo-app --template typescript
> ```
> Then copy the provided component files into the appropriate directories.

### Running Both Frontend and Backend
You can run both the frontend and backend concurrently using:
```
npm start
```
from the root directory.

## Evaluation Criteria
- **Code Quality**: Clean, maintainable, and well-structured code
- **Architecture**: Proper separation of concerns and design patterns
- **Performance**: Efficient algorithms and optimized React rendering
- **Error Handling**: Proper error handling and user feedback
- **UI/UX**: Intuitive and responsive user interface
- **Testing**: Comprehensive unit and integration tests

## Bonus Points
- Implementing real-time updates using SignalR
- Adding user authentication and authorization
- Creating a mobile-responsive design
- Implementing keyboard shortcuts for power users
- Adding dark mode support

## Submission
1. Fork this repository
2. Complete the challenge
3. Submit a pull request with your changes
4. Include a brief explanation of your implementation decisions

Good luck! 