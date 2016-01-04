package com.example.ivan.currencycalculator;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    private String currencySymbol;
    private Double lv;
    private Double sum;
    private EditText currentCurrency;
    private TextView calculatedSum;
    private EditText currencySymbolEditText;
    private EditText sumToCalculate;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        currentCurrency = (EditText)findViewById(R.id.currentCurrencyEditText);
        currencySymbolEditText = (EditText)findViewById(R.id.currencySymbolEditText);
        sumToCalculate =(EditText)findViewById(R.id.sumToCalculateEditText);
        calculatedSum = (TextView)findViewById(R.id.calculatedTextView);
    }

    public void sumOnClick(View view) {
        currencySymbol =String.valueOf(String.valueOf(currencySymbolEditText.getEditableText()));
        lv = Double.valueOf(String.valueOf(currentCurrency.getEditableText()));
        sum = Double.valueOf(String.valueOf(sumToCalculate.getEditableText()));
        sum = sum*lv;
        calculatedSum.setText(new StringBuilder().append(sum.toString()).append(currencySymbol.toString()));
    }

    public void ClearOnClick(View view) {
        currentCurrency.setText("");
        currencySymbolEditText.setText("");
        sumToCalculate.setText("");
        calculatedSum.setText("");
    }
}
