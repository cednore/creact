#!/bin/bash

# Setup script for the Task Management System coding challenge

echo "Setting up the Task Management System coding challenge..."

# Install root dependencies
echo "Installing root dependencies..."
npm install

# Setup backend
echo "Setting up backend..."
cd backend/TodoApi
dotnet restore
cd ../..

# Setup frontend
echo "Setting up frontend..."
cd frontend/todo-app
npm install
cd ../..

echo "Setup complete! You can now start the application with:"
echo "npm start"
echo ""
echo "This will start both the backend API and the frontend development server."
echo ""
echo "Good luck with the challenge!" 