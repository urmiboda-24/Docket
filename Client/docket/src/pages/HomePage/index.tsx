import Header from "@/Components/Header";
import { useState } from "react";
import { ChromePicker, PhotoshopPicker, SketchPicker } from "react-color";
const HomePage = () => {
  const [currentColor, setCurrentColor] = useState("#22194D");

  const handleChangeComplete = (color: any, event: any) => {
    console.log(event);
    console.log(color);

    if (color.hex !== currentColor) {
      setCurrentColor(color.hex);
    }
  };
  return (
    <>
      <Header
        component={
          <ChromePicker
            onChangeComplete={handleChangeComplete}
            color={currentColor}
          />
        }
      />
    </>
  );
};

export default HomePage;
