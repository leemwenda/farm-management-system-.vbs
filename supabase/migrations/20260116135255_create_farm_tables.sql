/*
  # Create Farm Management System Tables

  ## Overview
  This migration sets up the complete database schema for the farm management system,
  including tables for crops, livestock, employees, and financial transactions.

  ## New Tables Created

  ### 1. crops
  - `id` (uuid, primary key) - Unique identifier for each crop
  - `crop_name` (text) - Name of the crop
  - `crop_type` (text) - Type/category of the crop
  - `planting_date` (date) - Date when crop was planted
  - `quantity` (decimal) - Quantity in kilograms
  - `user_id` (uuid) - Reference to authenticated user
  - `created_at` (timestamptz) - Record creation timestamp

  ### 2. livestock
  - `id` (uuid, primary key) - Unique identifier for each animal
  - `animal_id` (text) - Custom animal identification number
  - `animal_type` (text) - Type of animal (Cow, Goat, Sheep, etc.)
  - `breed` (text) - Breed of the animal
  - `date_of_birth` (date) - Animal's date of birth
  - `gender` (text) - Male or Female
  - `weight` (decimal) - Weight in kilograms
  - `health_status` (text) - Current health status
  - `location` (text) - Location on the farm
  - `user_id` (uuid) - Reference to authenticated user
  - `created_at` (timestamptz) - Record creation timestamp

  ### 3. employees
  - `id` (uuid, primary key) - Unique identifier for each employee
  - `full_name` (text) - Employee's full name
  - `role` (text) - Job role (Manager, Farmhand, etc.)
  - `salary` (decimal) - Employee salary
  - `contact` (text) - Contact information
  - `user_id` (uuid) - Reference to authenticated user
  - `created_at` (timestamptz) - Record creation timestamp

  ### 4. finance
  - `id` (uuid, primary key) - Unique identifier for each transaction
  - `transaction_type` (text) - Type: income or expense
  - `description` (text) - Transaction description
  - `amount` (decimal) - Transaction amount
  - `transaction_date` (date) - Date of transaction
  - `user_id` (uuid) - Reference to authenticated user
  - `created_at` (timestamptz) - Record creation timestamp

  ## Security
  - Row Level Security (RLS) enabled on all tables
  - Users can only read their own data
  - Users can only insert their own data
  - Users can only update their own data
  - Users can only delete their own data
  - All policies check user authentication via auth.uid()

  ## Important Notes
  - All tables use UUID for primary keys with automatic generation
  - Created_at timestamps default to current time
  - Decimal fields use numeric type for precision
  - All policies are restrictive and require authentication
  - Data is isolated per user through user_id column
*/

-- Create crops table
CREATE TABLE IF NOT EXISTS crops (
  id uuid PRIMARY KEY DEFAULT gen_random_uuid(),
  crop_name text NOT NULL,
  crop_type text NOT NULL,
  planting_date date NOT NULL,
  quantity numeric(10, 2) NOT NULL DEFAULT 0,
  user_id uuid NOT NULL REFERENCES auth.users(id) ON DELETE CASCADE,
  created_at timestamptz DEFAULT now()
);

-- Create livestock table
CREATE TABLE IF NOT EXISTS livestock (
  id uuid PRIMARY KEY DEFAULT gen_random_uuid(),
  animal_id text NOT NULL,
  animal_type text NOT NULL,
  breed text NOT NULL,
  date_of_birth date NOT NULL,
  gender text NOT NULL,
  weight numeric(10, 2) NOT NULL DEFAULT 0,
  health_status text NOT NULL,
  location text NOT NULL,
  user_id uuid NOT NULL REFERENCES auth.users(id) ON DELETE CASCADE,
  created_at timestamptz DEFAULT now()
);

-- Create employees table
CREATE TABLE IF NOT EXISTS employees (
  id uuid PRIMARY KEY DEFAULT gen_random_uuid(),
  full_name text NOT NULL,
  role text NOT NULL,
  salary numeric(10, 2) NOT NULL DEFAULT 0,
  contact text NOT NULL,
  user_id uuid NOT NULL REFERENCES auth.users(id) ON DELETE CASCADE,
  created_at timestamptz DEFAULT now()
);

-- Create finance table
CREATE TABLE IF NOT EXISTS finance (
  id uuid PRIMARY KEY DEFAULT gen_random_uuid(),
  transaction_type text NOT NULL CHECK (transaction_type IN ('income', 'expense')),
  description text NOT NULL,
  amount numeric(10, 2) NOT NULL DEFAULT 0,
  transaction_date date NOT NULL,
  user_id uuid NOT NULL REFERENCES auth.users(id) ON DELETE CASCADE,
  created_at timestamptz DEFAULT now()
);

-- Enable Row Level Security on all tables
ALTER TABLE crops ENABLE ROW LEVEL SECURITY;
ALTER TABLE livestock ENABLE ROW LEVEL SECURITY;
ALTER TABLE employees ENABLE ROW LEVEL SECURITY;
ALTER TABLE finance ENABLE ROW LEVEL SECURITY;

-- Create RLS policies for crops table
CREATE POLICY "Users can view own crops"
  ON crops FOR SELECT
  TO authenticated
  USING (auth.uid() = user_id);

CREATE POLICY "Users can insert own crops"
  ON crops FOR INSERT
  TO authenticated
  WITH CHECK (auth.uid() = user_id);

CREATE POLICY "Users can update own crops"
  ON crops FOR UPDATE
  TO authenticated
  USING (auth.uid() = user_id)
  WITH CHECK (auth.uid() = user_id);

CREATE POLICY "Users can delete own crops"
  ON crops FOR DELETE
  TO authenticated
  USING (auth.uid() = user_id);

-- Create RLS policies for livestock table
CREATE POLICY "Users can view own livestock"
  ON livestock FOR SELECT
  TO authenticated
  USING (auth.uid() = user_id);

CREATE POLICY "Users can insert own livestock"
  ON livestock FOR INSERT
  TO authenticated
  WITH CHECK (auth.uid() = user_id);

CREATE POLICY "Users can update own livestock"
  ON livestock FOR UPDATE
  TO authenticated
  USING (auth.uid() = user_id)
  WITH CHECK (auth.uid() = user_id);

CREATE POLICY "Users can delete own livestock"
  ON livestock FOR DELETE
  TO authenticated
  USING (auth.uid() = user_id);

-- Create RLS policies for employees table
CREATE POLICY "Users can view own employees"
  ON employees FOR SELECT
  TO authenticated
  USING (auth.uid() = user_id);

CREATE POLICY "Users can insert own employees"
  ON employees FOR INSERT
  TO authenticated
  WITH CHECK (auth.uid() = user_id);

CREATE POLICY "Users can update own employees"
  ON employees FOR UPDATE
  TO authenticated
  USING (auth.uid() = user_id)
  WITH CHECK (auth.uid() = user_id);

CREATE POLICY "Users can delete own employees"
  ON employees FOR DELETE
  TO authenticated
  USING (auth.uid() = user_id);

-- Create RLS policies for finance table
CREATE POLICY "Users can view own finance"
  ON finance FOR SELECT
  TO authenticated
  USING (auth.uid() = user_id);

CREATE POLICY "Users can insert own finance"
  ON finance FOR INSERT
  TO authenticated
  WITH CHECK (auth.uid() = user_id);

CREATE POLICY "Users can update own finance"
  ON finance FOR UPDATE
  TO authenticated
  USING (auth.uid() = user_id)
  WITH CHECK (auth.uid() = user_id);

CREATE POLICY "Users can delete own finance"
  ON finance FOR DELETE
  TO authenticated
  USING (auth.uid() = user_id);

-- Create indexes for better query performance
CREATE INDEX IF NOT EXISTS idx_crops_user_id ON crops(user_id);
CREATE INDEX IF NOT EXISTS idx_crops_planting_date ON crops(planting_date);
CREATE INDEX IF NOT EXISTS idx_livestock_user_id ON livestock(user_id);
CREATE INDEX IF NOT EXISTS idx_livestock_animal_type ON livestock(animal_type);
CREATE INDEX IF NOT EXISTS idx_employees_user_id ON employees(user_id);
CREATE INDEX IF NOT EXISTS idx_finance_user_id ON finance(user_id);
CREATE INDEX IF NOT EXISTS idx_finance_transaction_date ON finance(transaction_date);
CREATE INDEX IF NOT EXISTS idx_finance_transaction_type ON finance(transaction_type);
