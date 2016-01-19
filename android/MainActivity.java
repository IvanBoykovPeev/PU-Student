package com.example.ivan.currencycalculator;

import android.content.Context;
import android.content.SharedPreferences;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    private String currencySymbol;
    private Double lv;
    private Double sum;
    private EditText currentCurrencyEditText;
    private TextView calculatedSumEditText;
    private EditText currencySymbolEditText;
    private EditText sumToCalculateEditText;
    SharedPreferences sharedPreferences;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        currentCurrencyEditText = (EditText)findViewById(R.id.currentCurrencyEditText);
        currencySymbolEditText = (EditText)findViewById(R.id.currencySymbolEditText);
        sumToCalculateEditText =(EditText)findViewById(R.id.sumToCalculateEditText);
        calculatedSumEditText = (TextView)findViewById(R.id.calculatedTextView);
        sharedPreferences = getSharedPreferences("MyPreferences" , Context.MODE_PRIVATE);
        sharedPreferences.getAll();
        currencySymbolEditText.setText(sharedPreferences.getString("currencySymbol", ""));
        Float sharedCurrency = sharedPreferences.getFloat("currency", 0.00f);
        currentCurrencyEditText.setText(sharedCurrency.toString());
    }

    public void sumOnClick(View view) {

        currencySymbol = String.valueOf(String.valueOf(currencySymbolEditText.getEditableText()));
        lv = Double.valueOf(String.valueOf(currentCurrencyEditText.getEditableText()));
        sum = Double.valueOf(String.valueOf(sumToCalculateEditText.getEditableText()));

        SharedPreferences.Editor editor = sharedPreferences.edit();
        editor.putString("currencySymbol",currencySymbol);
        editor.putFloat("currency", lv.floatValue());
        editor.commit();

        sum = sum*lv;
        calculatedSumEditText.setText(new StringBuilder().append(sum.toString()).append(currencySymbol.toString()));
    }

    public void ClearOnClick(View view) {
        currentCurrencyEditText.setText("");
        //currencySymbolEditText.setText("");
        sumToCalculateEditText.setText("");
        calculatedSumEditText.setText("");
    }
}
