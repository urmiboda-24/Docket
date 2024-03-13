import { Box, Button, Grid, Typography } from "@mui/material";
import { useRouter } from "next/router";

const ErrorPage = () => {
  const router = useRouter();

  const homeClick = () => {
    router.back();
  };
  return (
    <Grid container className="error-container">
      <Grid>
        <Box className="error-message-container">
          <Typography variant="h3">404</Typography>
          <Typography variant="h4">
            Oops, This Page Could Not Be Found.
          </Typography>
        </Box>
        <Box
          sx={{ display: "flex", justifyContent: "center", marginTop: "10px" }}
        >
          <Button variant="contained" type="button" onClick={homeClick}>
            Go Back
          </Button>
        </Box>
      </Grid>
    </Grid>
  );
};

export default ErrorPage;
