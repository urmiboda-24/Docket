import CommonModel from "@/Components/CommonComponents/Model";
import Header from "@/Components/Header";
import {
  Box,
  Button,
  FormControl,
  FormHelperText,
  InputLabel,
  MenuItem,
  Paper,
  Select,
  SelectChangeEvent,
  Table,
  TableBody,
  TableCell,
  TableContainer,
  TableHead,
  TableRow,
  TextField,
} from "@mui/material";
import React, { useState } from "react";
import { ChromePicker } from "react-color";

const ColorPalette = () => {
  const [open, setOpen] = useState<boolean>(false);
  const [currentColor, setCurrentColor] = useState("#22194D");
  const [documentType, setDocumentType] = useState(1);

  const handleChangeComplete = (color: any, event: any) => {
    console.log(event);
    console.log(color);

    if (color.hex !== currentColor) {
      setCurrentColor(color.hex);
    }
  };
  const handleOpenModel = () => {
    setOpen(true);
  };
  const handleCloseModel = () => {
    setOpen(false);
  };
  const handleSave = () => {
    setOpen(false);
  };
  const handleDocumentTypeChange = (event: SelectChangeEvent) => {
    setDocumentType(+event.target.value);
  };

  return (
    <>
      <Header
        component={
          <>
            <Box sx={{ display: "flex", justifyContent: "flex-end" }}>
              <Button onClick={handleOpenModel}>Add</Button>
            </Box>
            <CommonModel
              open={open}
              onClose={handleCloseModel}
              onSave={handleSave}
            >
              <FormControl sx={{ m: 1, minWidth: 120 }}>
                <InputLabel id="demo-simple-select-helper-label">
                  Document Type
                </InputLabel>
                <Select
                  value={documentType.toString()}
                  onChange={handleDocumentTypeChange}
                  label={"Document Type"}
                  fullWidth
                >
                  <MenuItem value="">
                    <em>None</em>
                  </MenuItem>
                  <MenuItem value={1}>PDF</MenuItem>
                  <MenuItem value={2}>Docx</MenuItem>
                  <MenuItem value={3}>PNG</MenuItem>
                  <MenuItem value={4}>JPG</MenuItem>
                </Select>
                <FormHelperText>{"Error"}</FormHelperText>
              </FormControl>
              <ChromePicker
                onChangeComplete={handleChangeComplete}
                color={currentColor}
              />
              <Button autoFocus onClick={handleCloseModel}>
                Cancel
              </Button>
              <Button autoFocus onClick={handleCloseModel}>
                Save
              </Button>
            </CommonModel>
            <TableContainer component={Paper}>
              <Table sx={{ minWidth: 650 }} aria-label="simple table">
                <TableHead>
                  <TableRow>
                    <TableCell>Document Type</TableCell>
                    <TableCell align="center">Colour</TableCell>
                    <TableCell align="center">Action</TableCell>
                  </TableRow>
                </TableHead>
                <TableBody>
                  <TableRow
                    sx={{ "&:last-child td, &:last-child th": { border: 0 } }}
                  >
                    <TableCell component="th" scope="row">
                      type
                    </TableCell>
                    <TableCell align="center">color</TableCell>
                    <TableCell align="center" component="th" scope="row">
                      <Box>
                        <Button>Edit</Button>
                        <Button>Delete</Button>
                      </Box>
                    </TableCell>
                  </TableRow>
                  {/* {rows.map((row) => (
                    <TableRow
                      key={row.name}
                      sx={{ "&:last-child td, &:last-child th": { border: 0 } }}
                    >
                      <TableCell component="th" scope="row">
                        {row.name}
                      </TableCell>
                      <TableCell align="right">{row.calories}</TableCell>
                      <TableCell align="right">{row.fat}</TableCell>
                      <TableCell align="right">{row.carbs}</TableCell>
                      <TableCell align="right">{row.protein}</TableCell>
                    </TableRow>
                  ))} */}
                </TableBody>
              </Table>
            </TableContainer>
          </>
        }
      />
    </>
  );
};

export default ColorPalette;
