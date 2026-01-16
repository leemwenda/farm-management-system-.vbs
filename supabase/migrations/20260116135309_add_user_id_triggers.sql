/*
  # Add Auto User ID Population

  ## Overview
  This migration adds database triggers to automatically populate the user_id field
  when new records are inserted. This ensures data is always associated with the
  correct user without requiring explicit user_id in INSERT statements.

  ## Changes
  1. Create a function that sets user_id to the current authenticated user
  2. Add triggers to all tables to call this function before INSERT operations

  ## Security
  - Function uses auth.uid() to get current authenticated user
  - Triggers run automatically on INSERT
  - Prevents accidental insertion of data with wrong user_id
*/

-- Create function to automatically set user_id
CREATE OR REPLACE FUNCTION set_user_id()
RETURNS TRIGGER AS $$
BEGIN
  NEW.user_id = auth.uid();
  RETURN NEW;
END;
$$ LANGUAGE plpgsql SECURITY DEFINER;

-- Create triggers for all tables
DROP TRIGGER IF EXISTS set_crops_user_id ON crops;
CREATE TRIGGER set_crops_user_id
  BEFORE INSERT ON crops
  FOR EACH ROW
  EXECUTE FUNCTION set_user_id();

DROP TRIGGER IF EXISTS set_livestock_user_id ON livestock;
CREATE TRIGGER set_livestock_user_id
  BEFORE INSERT ON livestock
  FOR EACH ROW
  EXECUTE FUNCTION set_user_id();

DROP TRIGGER IF EXISTS set_employees_user_id ON employees;
CREATE TRIGGER set_employees_user_id
  BEFORE INSERT ON employees
  FOR EACH ROW
  EXECUTE FUNCTION set_user_id();

DROP TRIGGER IF EXISTS set_finance_user_id ON finance;
CREATE TRIGGER set_finance_user_id
  BEFORE INSERT ON finance
  FOR EACH ROW
  EXECUTE FUNCTION set_user_id();
