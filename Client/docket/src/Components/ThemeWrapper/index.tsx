import projectTheme from "@/theme";
import { ThemeProvider } from "@mui/material/styles";
import React from "react";

interface ThemeWrapperProps {
  children: React.ReactNode;
}

const ThemeWrapper: React.FC<ThemeWrapperProps> = ({ children }) => {
  return <ThemeProvider theme={projectTheme}>{children}</ThemeProvider>;
};

export default ThemeWrapper;
