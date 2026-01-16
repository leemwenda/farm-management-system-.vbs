# Farm Management System

A modern web-based farm management system built with Vite, vanilla JavaScript, and Supabase. This application helps farmers manage crops, livestock, employees, finances, and generate reports.

## Features

- **Authentication**: Secure email/password authentication with Supabase
- **Crops Management**: Track crop names, types, planting dates, and quantities
- **Livestock Management**: Monitor animals with details like ID, type, breed, health status, and location
- **Employee Management**: Manage farm staff with roles, salaries, and contact information
- **Finance Management**: Track income and expenses with visual summaries
- **Reports**: Generate comprehensive reports for all farm activities

## Prerequisites

- Node.js (v18 or higher)
- A Supabase account and project

## Setup Instructions

### 1. Supabase Configuration

The database schema and authentication are already set up automatically. You need to:

1. Get your Supabase project URL and anon key from your [Supabase Dashboard](https://app.supabase.com)
2. Update the `.env` file with your credentials:

```env
VITE_SUPABASE_URL=your_supabase_project_url
VITE_SUPABASE_ANON_KEY=your_supabase_anon_key
```

### 2. Create Your First User

Since this is a new application, you need to create a user account:

1. Go to your Supabase Dashboard
2. Navigate to Authentication > Users
3. Click "Add User"
4. Enter an email and password
5. Click "Create User"

Alternatively, you can enable email signup in Supabase:
- Go to Authentication > Settings
- Enable "Enable Email Signup"
- Then you can register directly from the login page

### 3. Install Dependencies

Dependencies are already installed. If needed, run:

```bash
npm install
```

### 4. Start the Development Server

The development server is automatically started for you. If you need to start it manually:

```bash
npm run dev
```

The application will be available at `http://localhost:3000`

## Usage

### Login
1. Open the application in your browser
2. Enter your email and password
3. Click "Login"

### Managing Data

#### Crops
- Click on "Crops Management" from the dashboard
- Fill in crop details (name, type, planting date, quantity)
- Click "Add Crop" to save
- Use Edit/Delete buttons to modify or remove crops

#### Livestock
- Click on "Livestock Management"
- Enter animal details (ID, type, breed, date of birth, etc.)
- Click "Add Livestock" to save
- Age is automatically calculated from date of birth

#### Employees
- Click on "Employee Management"
- Enter employee details (name, role, salary, contact)
- Click "Add Employee" to save

#### Finance
- Click on "Finance Management"
- Select transaction type (Income or Expense)
- Enter description, amount, and date
- View financial summary at the top showing total income, expenses, and profit/loss

#### Reports
- Click on "Reports"
- Select report type from the dropdown
- Click "Generate Report" to view analytics

## Database Structure

All data is stored in Supabase with the following tables:

- **crops**: Stores crop information
- **livestock**: Stores animal records
- **employees**: Stores employee data
- **finance**: Stores financial transactions

Each table has Row Level Security (RLS) enabled, ensuring users can only access their own data.

## Security Features

- Email/password authentication via Supabase Auth
- Row Level Security on all database tables
- User data isolation (users only see their own records)
- Automatic user_id assignment on data insertion
- Secure API calls through Supabase client

## Technologies Used

- **Frontend**: HTML, CSS, JavaScript (ES6+)
- **Build Tool**: Vite
- **Database**: Supabase (PostgreSQL)
- **Authentication**: Supabase Auth
- **Styling**: Custom CSS with responsive design

## Project Structure

```
├── index.html              # Main HTML file
├── package.json            # Dependencies
├── vite.config.js         # Vite configuration
├── .env                   # Environment variables
└── src/
    ├── main.js            # Application entry point
    ├── config/
    │   └── supabase.js    # Supabase client configuration
    ├── modules/
    │   ├── auth.js        # Authentication logic
    │   ├── dashboard.js   # Dashboard functionality
    │   ├── crops.js       # Crops management
    │   ├── livestock.js   # Livestock management
    │   ├── employees.js   # Employee management
    │   ├── finance.js     # Finance management
    │   └── reports.js     # Reports generation
    └── styles/
        └── main.css       # Application styles
```

## Building for Production

To create a production build:

```bash
npm run build
```

The built files will be in the `dist/` directory, ready for deployment.

## Troubleshooting

### Login Issues
- Ensure your Supabase URL and anon key are correct in `.env`
- Verify the user exists in Supabase Dashboard > Authentication
- Check browser console for error messages

### Data Not Showing
- Ensure you're logged in
- Check that RLS policies are enabled in Supabase
- Verify data exists for the logged-in user

### Connection Errors
- Confirm your Supabase project is active
- Check your internet connection
- Verify the Supabase URL is accessible

## License

MIT License - See LICENSE file for details
