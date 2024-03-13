import { createTheme } from "@mui/material/styles";

const primaryMain = "#01bce9";
const secondaryMain = "#9E9E9E";
const textSecondary = "#616161";
const textPrimary = "#000000";
const textInput = "#424242";
const errorColor = "#d32f2f";
const BtnColor = "#f32d97";
const hoverBtnColor = "#ce2780";

const projectTheme = createTheme({
  palette: {
    primary: {
      main: primaryMain,
    },
    secondary: {
      main: secondaryMain,
    },
    text: {
      primary: textPrimary,
      secondary: textSecondary,
    },
    error: {
      main: errorColor,
    },
    background: {
      default: "#FFFFFF",
    },
  },
  spacing: 8,
  typography: {
    fontFamily: "Nunito Sans,sans-serif",
    h1: {
      fontSize: 44,
      lineHeight: "50px",
      fontWeight: "bold",
      "@media(max-width:1199px)": {
        fontSize: 36,
        lineHeight: "42px",
      },
      "@media(max-width:599px)": {
        fontSize: 30,
        lineHeight: "36px",
      },
    },
    h2: {
      fontSize: 24,
      lineHeight: "30px",
      fontWeight: "bold",
      "@media(max-width:599px)": {
        fontSize: 20,
        lineHeight: "26px",
      },
    },
    h3: {
      fontSize: 20,
      lineHeight: "30px",
      fontWeight: "bold",
      "@media(max-width:599px)": {
        fontSize: 18,
        lineHeight: "24px",
      },
    },
    h4: {
      fontSize: 18,
      lineHeight: "24px",
      fontWeight: 600,
      "@media(max-width:599px)": {
        fontSize: 16,
        lineHeight: "22px",
      },
    },
    h5: {
      fontSize: 16,
      lineHeight: "20px",
      fontWeight: 400,
      "@media(max-width:599px)": {
        fontSize: 14,
        lineHeight: "20px",
      },
    },
    h6: {
      fontSize: 14,
      lineHeight: "20px",
      fontWeight: 400,
    },
    body1: {
      fontSize: 16,
      lineHeight: "24px",
      "@media(max-width:599px)": {
        fontSize: 14,
        lineHeight: "20px",
      },
    },
    body2: {
      fontSize: 14,
      lineHeight: "20px",

      "@media(max-width:599px)": {
        fontSize: 12,
        lineHeight: "16px",
      },
    },
    subtitle1: {
      fontSize: 12,
      lineHeight: "18px",
    },
  },
  components: {
    MuiPaper: {},
    MuiLink: {
      styleOverrides: {
        root: {
          textDecoration: "none",
          color: "#ffffff",
          "&:hover": {
            color: "#f32d97",
          },
        },
      },
    },
    MuiIconButton: {
      styleOverrides: {
        root: {
          borderRadius: "20px",
          backgroundColor: "rgba(255, 255, 255, 0.1)",
          fontWeight: 500,
          fontSize: 14,
          lineHeight: "36px",
          letterSpacing: "0.25px",
          textTransform: "capitalize",
          "&:hover": {
            backgroundColor: hoverBtnColor,
          },
        },
      },
    },
    MuiButton: {
      styleOverrides: {
        root: {
          borderRadius: "20px",
          fontWeight: 500,
          fontSize: 14,
          lineHeight: "36px",
          letterSpacing: "0.25px",
          textTransform: "capitalize",
        },
        sizeMedium: {
          padding: 0,
        },
        sizeLarge: {
          padding: "4px 16px",
        },
        textPrimary: {
          paddingTop: "4px",
          paddingBottom: "4px",
          "&.MuiButton-sizeSmall": {
            padding: "3px 16px",
          },
          "&.Mui-disabled": {
            color: "#9E9E9E",
          },
        },
        outlinedPrimary: {
          color: "#f32d97",
          boxShadow: "none",
          position: "relative",
          borderColor: "#f32d97",
          "&:hover:not(.Mui-disabled), &:focus:not(.Mui-disabled), &:active:not(.Mui-disabled)":
            {
              boxShadow: `inset 0 0 0 50px #f32d97`,
              color: "#FFFFFF",
              borderColor: "#f32d97",
            },
          "&.MuiButton-sizeMedium": {
            paddingTop: "3px",
            paddingBottom: "3px",
          },
          "&.MuiButton-sizeSmall": {
            padding: "3px 16px",
          },
          "&.Mui-disabled": {
            color: "#9E9E9E",
            border: "1px solid #9E9E9E",
          },
        },
        containedPrimary: {
          color: "#FFFFFF",
          boxShadow: "none",
          position: "relative",
          backgroundColor: "#f32d97",
          "&.MuiButton-sizeMedium": {
            padding: "4px 16px",
          },
          "&:hover": {
            boxShadow: "none",
            backgroundColor: hoverBtnColor,
          },
          "&:active": {
            transform: "scale(0.97)",
          },
          "&.Mui-disabled": {
            color: "#9E9E9E",
            backgroundColor: "#E0E0E0",
          },
        },
        containedSecondary: {
          color: "#FFFFFF",
          boxShadow: "none",
          backgroundColor: "#232323",
          position: "relative",
          "&.MuiButton-sizeMedium": {
            padding: "4px 24px",
          },
          "&:hover": {
            boxShadow: "none",
            backgroundColor: "#333333",
          },
          "&:active": {
            transform: "scale(0.97)",
          },
          "&.Mui-disabled": {
            color: "#424242",
            backgroundColor: "#EEEEEE",
            opacity: "0.6",
          },
        },
      },
    },
  },
});

export default projectTheme;
